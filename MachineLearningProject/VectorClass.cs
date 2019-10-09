using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;

namespace MachineLearningProject
{
    class VectorClass
    {
        public List<String> vectorList = new List<string>();
        public List<String> unknownTextList = new List<string>();
        public MainWindow mainUI = new MainWindow();
        public Stemming stemming = new Stemming();
        public List<String> FillVectorList()
        {


            return vectorList;
        }

        public void CompareLists()
        {
            
           
        }

    }
}
