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
            foreach (var nascarWord in nascarClass.FillNascarList())
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

            foreach (var musicWord in musicClass.FillMusicList())
            {
                //since since a word might be repeated it is filtered out
                if (dictionaryList.Contains(musicWord))
                {

                    Console.WriteLine("\n");
                }
                //if the word isnt inside the list then it is added after it has been stemmed
                else if (musicWord.Equals(" "))
                {

                }
                else
                {

                    string tempStemmer = stemmer.stem(musicWord);
                    dictionaryList.Add(tempStemmer);
                }
            }

            Console.WriteLine(dictionaryList.Count);
            return dictionaryList;
        }

    }
}
