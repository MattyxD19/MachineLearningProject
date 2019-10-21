using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;


namespace MachineLearningProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public List<string> compareList = new List<string>();
        public OpenFileDialog fileBrowser = new OpenFileDialog();

        //just used for testing/debugging
        Stemming stemmer = new Stemming();
        Nascar nascar = new Nascar();
        Music music = new Music();
        

        private void SelectFileToRead_Click(object sender, RoutedEventArgs e)
        {
            Output.Clear();
            fileBrowser.ShowDialog();
            DirectoryInfo selectedFile = new DirectoryInfo(fileBrowser.FileName);
            StreamReader sr = new StreamReader(selectedFile.FullName);

            while (!sr.EndOfStream)
            {
                Output.AppendText(sr.ReadToEnd());
            }
            
            StartReading.IsEnabled = true;

        }

        private void StartReading_Click(object sender, RoutedEventArgs e)
        {
            DictionaryListView.Items.Clear();
            VectorListView.Items.Clear();

            DirectoryInfo selectedFile = new DirectoryInfo(fileBrowser.FileName);
            StreamReader sr = new StreamReader(selectedFile.FullName);

            DictionaryClass dictionaryList = new DictionaryClass();
            
            //dictionaryList.FillDictionaryList();

            foreach (var item in dictionaryList.FillDictionaryList())
            {
                DictionaryListView.Items.Add(item);
            }

            string[] unknownTextArray = sr.ReadToEnd()
                            .Split(' ');

            for (int i = 0; i < DictionaryListView.Items.Count; i++)
            {
                if (i < unknownTextArray.Length)
                {
                    string tempStemmer = stemmer.stem(unknownTextArray[i]);
                    compareList.Add(tempStemmer);

                    if (nascar.FillNascarList1().Contains(tempStemmer))
                    {
                        VectorListView.Items.Add(1);
                    }
                    else if (nascar.FillNascarList2().Contains(tempStemmer))
                    {
                        VectorListView.Items.Add(1);
                    }
                    else if (nascar.FillNascarList3().Contains(tempStemmer))
                    {
                        VectorListView.Items.Add(1);
                    }
                    else if (nascar.FillNascarList4().Contains(tempStemmer))
                    {
                        VectorListView.Items.Add(1);
                    }
                    else if (nascar.FillNascarList5().Contains(tempStemmer))
                    {
                        VectorListView.Items.Add(1);
                    }
                    else if (music.FillMusicList6().Contains(tempStemmer))
                    {
                        VectorListView.Items.Add(1);
                    }
                    else if (music.FillMusicList7().Contains(tempStemmer))
                    {
                        VectorListView.Items.Add(1);
                    }
                    else if (music.FillMusicList8().Contains(tempStemmer))
                    {
                        VectorListView.Items.Add(1);
                    }
                    else if (music.FillMusicList9().Contains(tempStemmer))
                    {
                        VectorListView.Items.Add(1);
                    }
                    else if (music.FillMusicList10().Contains(tempStemmer))
                    {
                        VectorListView.Items.Add(1);
                    }
                    else
                    {
                        VectorListView.Items.Add(0);
                    }
                }
                else
                {
                    VectorListView.Items.Add(0);
                }   
            }

            ShowNearestNeighborg.IsEnabled = true;

            Console.WriteLine(VectorListView.Items.Count);
            Console.WriteLine("compareList: " + compareList.Count);
        }

        private void ShowNearestNeighborg_Click(object sender, RoutedEventArgs e)
        {
            /**
            Vector distanceVector(int x, int y)
            {
               
            }
            **/
            
        }
    }
}
