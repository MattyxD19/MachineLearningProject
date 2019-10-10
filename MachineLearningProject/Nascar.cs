using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MachineLearningProject
{
    class Nascar
    {
        public List<String> NascarList = new List<string>();
        

        public List<String> FillNascarList()
        {

            try
            {

                string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                for (int i = 1; i <= 5; i++)
                {

                    string tempFileNameHolder = "{0}Resources\\" + i.ToString() + ".txt";
                    string FileName = string.Format(tempFileNameHolder, Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

                    StreamReader file = new StreamReader(FileName);

                    if (file != null)
                    {
                        /*
                         * Add all the words from the texts to a single list
                         * the words have the dot and comma removed, as well as white spaces
                         */
                        while (!file.EndOfStream)
                        {
                            string[] singleWord = file.ReadLine()
                                .Split(' ', ',', '!', '.', '"', '(', ')', '-', '?');


                            foreach (var word in singleWord)
                            {
                                NascarList.Add(word);
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("File not found!");
            }
            return NascarList;
        }
    }
}
