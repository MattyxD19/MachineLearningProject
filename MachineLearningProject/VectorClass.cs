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
        public MainWindow mainUI = new MainWindow();
        public List<String> FillVectorList()
        {


            return vectorList;
        }

        public void CompareLists(RichTextBox rtb)
        {
            TextRange textRange = new TextRange(
                mainUI.Output.Document.ContentStart,
                mainUI.Output.Document.ContentEnd
                );

            string[] selectedFile = textRange.Text;
        }

    }
}
