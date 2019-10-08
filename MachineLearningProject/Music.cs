﻿using System;
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

                        string[] singleWord = file.ReadToEnd().ToLower()
                            .Split(' ', ',', '.', '(', ')', '"', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-', '?');


                        foreach (var word in singleWord)
                        {
                            if (MusicList.Contains(word))
                            {
                                Console.WriteLine("Word is already in the dictionary");
                            }

                            else
                            {
                                Console.WriteLine(word);
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
            Console.WriteLine("size of list: " + MusicList.Count());
            return MusicList;
        }
        
    }
}

