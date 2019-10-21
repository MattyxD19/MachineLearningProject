using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MachineLearningProject
{
    class Nascar
    {

        public List<String> FillNascarList1()
        {
            List<String> NascarList1 = new List<String>();

            try
            {
                string RunningPath = AppDomain.CurrentDomain.BaseDirectory;

                string tempFileNameHolder = "{0}Resources\\" + "1" + ".txt";
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
                            .Split(' ');


                        foreach (var word in singleWord)
                        {
                            NascarList1.Add(word);
                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show("File not found!");
            }
            return NascarList1;
        }

        public List<String> FillNascarList2()
        {
            List<String> NascarList2 = new List<String>();

            try
            {
                string RunningPath = AppDomain.CurrentDomain.BaseDirectory;


                string tempFileNameHolder = "{0}Resources\\" + "2" + ".txt";
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
                            .Split(' ');


                        foreach (var word in singleWord)
                        {
                            NascarList2.Add(word);
                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show("File not found!");
            }
            return NascarList2;
        }

        public List<String> FillNascarList3()
        {
            List<String> NascarList3 = new List<String>();

            try
            {
                string RunningPath = AppDomain.CurrentDomain.BaseDirectory;


                string tempFileNameHolder = "{0}Resources\\" + "3" + ".txt";
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
                            .Split(' ');


                        foreach (var word in singleWord)
                        {
                            NascarList3.Add(word);
                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show("File not found!");
            }
            return NascarList3;
        }

        public List<String> FillNascarList4()
        {
            List<String> NascarList4 = new List<String>();

            try
            {
                string RunningPath = AppDomain.CurrentDomain.BaseDirectory;


                string tempFileNameHolder = "{0}Resources\\" + "4" + ".txt";
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
                            .Split(' ');


                        foreach (var word in singleWord)
                        {
                            NascarList4.Add(word);
                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show("File not found!");
            }
            return NascarList4;
        }

        public List<String> FillNascarList5()
        {
            List<String> NascarList5 = new List<String>();

            try
            {
                string RunningPath = AppDomain.CurrentDomain.BaseDirectory;


                string tempFileNameHolder = "{0}Resources\\" + "5" + ".txt";
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
                            NascarList5.Add(word);
                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show("File not found!");
            }
            return NascarList5;
        }
    }
}

