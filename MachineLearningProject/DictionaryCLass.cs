using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningProject
{
    class DictionaryClass
    {
        public Music musicClass = new Music();
        public Nascar nascarClass = new Nascar();
        public List<String> dictionaryList = new List<string>();
        Stemming stemmer = new Stemming();

        public List<String> FillDictionaryList()
        {
            foreach (var nascarWord in nascarClass.FillNascarList1())
            {
                if (nascarWord.Equals(" "))
                {

                }
                else
                {
                    string tempStemmer = stemmer.stem(nascarWord);
                    dictionaryList.Add(tempStemmer);
                }
            }
            foreach (var nascarWord in nascarClass.FillNascarList2())
            {
                if (nascarWord.Equals(" "))
                {

                }
                else
                {
                    string tempStemmer = stemmer.stem(nascarWord);
                    dictionaryList.Add(tempStemmer);
                }
            }
            foreach (var nascarWord in nascarClass.FillNascarList3())
            {
                if (nascarWord.Equals(" "))
                {

                }
                else
                {
                    string tempStemmer = stemmer.stem(nascarWord);
                    dictionaryList.Add(tempStemmer);
                }
            }
            foreach (var nascarWord in nascarClass.FillNascarList4())
            {
                if (nascarWord.Equals(" "))
                {

                }
                else
                {
                    string tempStemmer = stemmer.stem(nascarWord);
                    dictionaryList.Add(tempStemmer);
                }
            }
            foreach (var nascarWord in nascarClass.FillNascarList5())
            {
                if (nascarWord.Equals(" "))
                {

                }
                else
                {
                    string tempStemmer = stemmer.stem(nascarWord);
                    dictionaryList.Add(tempStemmer);
                }
            }

            foreach (var musicWord in musicClass.FillMusicList6())
            {
                //if the word isnt inside the list then it is added after it has been stemmed
                if (musicWord.Equals(" "))
                {

                }
                else
                {

                    string tempStemmer = stemmer.stem(musicWord);
                    if (dictionaryList.Contains(tempStemmer))
                    {
                        Console.WriteLine("\n");
                    }
                    else
                    {
                       dictionaryList.Add(tempStemmer);
                    }
                }

            }

            foreach (var musicWord in musicClass.FillMusicList7())
            {
                //if the word isnt inside the list then it is added after it has been stemmed
                if (musicWord.Equals(" "))
                {

                }
                else
                {

                    string tempStemmer = stemmer.stem(musicWord);
                    if (dictionaryList.Contains(tempStemmer))
                    {
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        dictionaryList.Add(tempStemmer);
                    }
                }

            }

            foreach (var musicWord in musicClass.FillMusicList8())
            {
                //if the word isnt inside the list then it is added after it has been stemmed
                if (musicWord.Equals(" "))
                {

                }
                else
                {

                    string tempStemmer = stemmer.stem(musicWord);
                    if (dictionaryList.Contains(tempStemmer))
                    {
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        dictionaryList.Add(tempStemmer);
                    }
                }

            }

            foreach (var musicWord in musicClass.FillMusicList9())
            {
                //if the word isnt inside the list then it is added after it has been stemmed
                if (musicWord.Equals(" "))
                {

                }
                else
                {

                    string tempStemmer = stemmer.stem(musicWord);
                    if (dictionaryList.Contains(tempStemmer))
                    {
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        dictionaryList.Add(tempStemmer);
                    }
                }

            }

            foreach (var musicWord in musicClass.FillMusicList10())
            {
                //if the word isnt inside the list then it is added after it has been stemmed
                if (musicWord.Equals(" "))
                {

                }
                else
                {

                    string tempStemmer = stemmer.stem(musicWord);
                    if (dictionaryList.Contains(tempStemmer))
                    {
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        dictionaryList.Add(tempStemmer);
                    }
                }

            }

            Console.WriteLine(dictionaryList.Count);
            return dictionaryList;
        }

    }
}
