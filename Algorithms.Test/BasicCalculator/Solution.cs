using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Test.BasicCalculator
{
    public static class Solution
    {
        private static readonly Stack<int> _operandStack = new Stack<int>();
        private static readonly Stack<char> _operatorStack = new Stack<char>();

        public static int Calculate(string s)
        {
            s = s.Trim();
            StringBuilder currentOperand = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                bool isLastChar = i == s.Length - 1;

                if (Char.IsDigit(c))
                    currentOperand.Append(c);

                if (c == '-' && IsUnaryOperation(s, i))
                {
                    currentOperand.Append(c);
                    continue; // Skip operator evaluation
                }
                
                if (currentOperand.Length > 0 && (!Char.IsDigit(c) || isLastChar))
                {
                    _operandStack.Push(int.Parse(currentOperand.ToString()));
                    currentOperand.Clear();
                }

                if (c == '(')
                {
                    _operatorStack.Push(c);
                }
                else if (c == ')')
                {
                    while (_operatorStack.Count > 0
                        && _operatorStack.Peek() != '(')
                    {
                        ExecuteOperation(_operatorStack.Pop());
                    }

                    _operatorStack.Pop(); // Discard '('
                }
                else if (!Char.IsDigit(c) && c != ' ') // c is an operator...
                {
                    // while stack has higher precedence operators, execute them first
                    while(_operatorStack.Count > 0
                        && Precedence(_operatorStack.Peek()) >= Precedence(c))
                    {
                        ExecuteOperation(_operatorStack.Pop());
                    }
                    _operatorStack.Push(c);
                }
            }

            // Execute remaining operations
            while (_operatorStack.Count > 0)
            {
                ExecuteOperation(_operatorStack.Pop());
            }

            return _operandStack.Pop();
        }

        private static bool IsUnaryOperation(string exp, int opIndex)
        {
            bool pushZero = false;
            bool okBackward = false;
            for (int j = opIndex -1; j >= 0; j--)
            {
                char x = exp[j];
                if (x == ' ')
                    continue;
                else if (Char.IsDigit(x) || x == ')')
                {
                    okBackward = false;
                    break;
                }
                else
                {
                    if (x == '(')
                        pushZero = true;

                    okBackward = true;
                    break;
                }
            }

            bool okForward = false;
            for (int i = 0; i < exp.Length; i++)
            {
                char x = exp[i];
                if (x == ' ')
                    continue;
                else if (char.IsDigit(x))
                {
                    okForward = true;
                    pushZero = false;
                    break;
                }
                else if (x == '(')
                {
                    okForward = false;
                    break;
                }
            }

            // Ensures correct operand stack sequence
            if (pushZero)
                _operandStack.Push(0);

            return okBackward && okForward;
        }

        private static void ExecuteOperation(char op)
        {
            int rightOperand = _operandStack.Pop();
            bool hasLeftOperand = _operandStack.TryPop(out int leftOperand);

            switch (op)
            {
                case '+':
                    _operandStack.Push(leftOperand + rightOperand);
                    break;
                case '-':
                    if (hasLeftOperand)
                        _operandStack.Push(leftOperand - rightOperand);
                    else
                        _operandStack.Push(-rightOperand);
                    break;
                case '*':
                    _operandStack.Push(leftOperand * rightOperand);
                    break;
                case '/':
                    _operandStack.Push(leftOperand / rightOperand);
                    break;
            }
        }

        private static int Precedence(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                default:
                    return 0;
            }
        }
    }
}
