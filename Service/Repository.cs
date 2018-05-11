using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Contract;
using Domain;

namespace Service
{
    public class Repository : IRepository {
        public Point GetPoint(int key) => DataClass.Points[key];
    }

    public static class DataClass {
        public static List<Point> Points { get; } = new List<Point>
        {
            new Point{X = 1, Y = 1},
            new Point{X = 2, Y = 2},
            new Point{X = 3, Y = 3},
            new Point{X = 4, Y = 4},
            new Point{X = 5, Y = 5},
            new Point{X = 6, Y = 6},
            new Point{X = 7, Y = 7},
            new Point{X = 8, Y = 8},
            new Point{X = 9, Y = 9},
            new Point{X = 10, Y = 10}
        };
    }
}
