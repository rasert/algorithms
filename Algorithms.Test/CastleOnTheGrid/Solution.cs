using System;
using System.Collections.Generic;

namespace Algorithms.Test.CastleOnTheGrid
{
    public class Point : IEquatable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Depth { get; set; }

        public Point(int x, int y, int depth = 0)
        {
            X = x;
            Y = y;
            Depth = depth;
        }

        public bool Equals(Point p)
        {
            if (p == null)
                return false;

            return X == p.X && Y == p.Y;
        }

        public override string ToString()
        {
            return $"{X}-{Y}";
        }
    }

    public static class Solution
    {

        private static readonly Point east = new Point(1, 0);
        private static readonly Point west = new Point(-1, 0);
        private static readonly Point south = new Point(0, 1);
        private static readonly Point north = new Point(0, -1);
        private static readonly Point[] directions = { east, south, west, north };

        private static Point[] GetFreeNeighbors(List<string> grid, Point current)
        {
            int n = grid.Count;
            List<Point> neighbors = new List<Point>();

            // Checks the four directions
            for (int i = 0; i < 4; i++)
            {
                Point dir = directions[i];
                Point next = new Point(current.X + dir.X, current.Y + dir.Y, current.Depth + 1);

                while (next.X >= 0 && next.X < n
                    && next.Y >= 0 && next.Y < n
                    && grid[next.X][next.Y] != 'X')
                {
                    neighbors.Add(next);
                    next = new Point(next.X + dir.X, next.Y + dir.Y, current.Depth + 1);
                }
            }

            return neighbors.ToArray();
        }

        public static int minimumMoves(List<string> grid, int startX, int startY, int goalX, int goalY)
        {
            Queue<Point> q = new Queue<Point>();
            HashSet<string> visited = new HashSet<string>();

            if (grid.Count == 0)
                return 0;

            Point goal = new Point(goalX, goalY);
            Point start = new Point(startX, startY);
            q.Enqueue(start);
            visited.Add(start.ToString());

            // BFS technique
            while (q.Count > 0)
            {
                Point current = q.Dequeue();

                if (current.Equals(goal))
                {
                    return current.Depth;
                }

                var freeNeighbors = GetFreeNeighbors(grid, current);
                foreach (Point next in freeNeighbors)
                {
                    // Check if already visited
                    if (visited.Contains(next.ToString()))
                        continue;

                    q.Enqueue(next);
                    visited.Add(next.ToString());
                }
            }

            return 0;
        }
    }
}
