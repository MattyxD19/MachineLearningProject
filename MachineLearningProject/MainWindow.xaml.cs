using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            
            dictionaryList.FillDictionaryList();

            foreach (var item in dictionaryList.FillDictionaryList())
            {
                DictionaryListView.Items.Add(item);
            }

            string[] unknownTextArray = sr.ReadToEnd()
                            .Split(' ', ',', '!', '.', '"', '(', ')', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-', '\n', '?');
                foreach (var word in unknownTextArray)
                {
                    string tempStemmer = stemmer.stem(word);
                    compareList.Add(tempStemmer);

                    if (nascar.FillNascarList().Contains(tempStemmer))
                    {
                        VectorListView.Items.Add("1");
                    }
                    else if(music.FillMusicList().Contains(tempStemmer))
                    {
                        VectorListView.Items.Add(1);
                    }
                    else
                    {
                        VectorListView.Items.Add("0");
                    }

                }
        }
    }
}
