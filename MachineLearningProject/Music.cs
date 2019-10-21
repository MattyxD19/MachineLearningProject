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

        public List<String> FillMusicList6()
        {
            List<String> MusicList6 = new List<String>();

            try
            {
                string RunningPath = AppDomain.CurrentDomain.BaseDirectory;

                    string tempFileNameHolder = "{0}Resources\\" + "6" + ".txt";
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
                                MusicList6.Add(word);
                            }
                        }
                    
                }
            }
            catch
            {
                MessageBox.Show("File not found!");
            }
            return MusicList6;
        }

        public List<String> FillMusicList7()
        {
            List<String> MusicList7 = new List<String>();

            try
            {
                string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                

                    string tempFileNameHolder = "{0}Resources\\" + "7" + ".txt";
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
                                MusicList7.Add(word);
                            }
                        }
                    
                }
            }
            catch
            {
                MessageBox.Show("File not found!");
            }
            return MusicList7;
        }

        public List<String> FillMusicList8()
        {
            List<String> MusicList8 = new List<String>();

            try
            {
                string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
              

                    string tempFileNameHolder = "{0}Resources\\" + "8" + ".txt";
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
                                MusicList8.Add(word);
                            }
                        }
                    
                }
            }
            catch
            {
                MessageBox.Show("File not found!");
            }
            return MusicList8;
        }

        public List<String> FillMusicList9()
        {
            List<String> MusicList9 = new List<String>();

            try
            {
                string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                

                    string tempFileNameHolder = "{0}Resources\\" + "9"+ ".txt";
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
                                MusicList9.Add(word);
                            }
                        }
                    
                }
            }
            catch
            {
                MessageBox.Show("File not found!");
            }
            return MusicList9;
        }

        public List<String> FillMusicList10()
        {
            List<String> MusicList10 = new List<String>();

            try
            {
                string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                

                    string tempFileNameHolder = "{0}Resources\\" + "10" + ".txt";
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
                                MusicList10.Add(word);
                            }
                        }
                    
                }
            }
            catch
            {
                MessageBox.Show("File not found!");
            }
            return MusicList10;
        }
    }
}

