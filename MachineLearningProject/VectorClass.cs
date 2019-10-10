using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace MachineLearningProject
{
    class VectorClass
    {
        public List<String> vectorList = new List<string>();
        public List<String> unknownTextList = new List<string>();
        public MainWindow mainUI = new MainWindow();

        public Point v1, v2;

        public void CalculateVectors(Point p1, Point p2)
        {


            double lenghtSquared = (p2 - p1).LengthSquared;
        }

    }
}
