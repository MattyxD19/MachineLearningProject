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

        public string ViewListword {get; set;}

        private void SelectFileToRead_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileBrowser = new OpenFileDialog();
            fileBrowser.ShowDialog();
            DirectoryInfo selectedFile = new DirectoryInfo(fileBrowser.FileName);
            StreamReader sr = new StreamReader(selectedFile.FullName);

            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
                Output.Document.Blocks.Add(new Paragraph(new Run(sr.ReadLine())));
            }
           


        }

        private void StartReading_Click(object sender, RoutedEventArgs e)
        {

            Nascar NascarArticles = new Nascar();
            selectFileToRead.IsEnabled = true;
            NascarArticles.FillDictionary();

            foreach (var item in NascarArticles.NascarList)
            {
                DictionaryListView.Items.Add(item);
            }
        }
    }
}
