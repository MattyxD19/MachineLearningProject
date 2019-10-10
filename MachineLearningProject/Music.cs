using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MachineLearningProject
{
    class Music
    {

        public List<String> FillMusicList()
        {
            List<String> MusicList = new List<String>();
           
            try
            {
                string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                for (int i = 6; i <= 10; i++)
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
                                MusicList.Add(word);
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("File not found!");
            }
            return MusicList;
        }
    }
}

