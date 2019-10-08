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

        public List<String> FillDictionaryList()
        {
            foreach (var nascarWord in nascarClass.FillNascarList())
            {
                dictionaryList.Add(nascarWord);
            }

            foreach (var musicWord in musicClass.FillMusicList())
            {
                if (dictionaryList.Contains(musicWord))
                {
                    Console.WriteLine("the word: " + musicWord + " is already in the list");
                }
                else
                {
                    dictionaryList.Add(musicWord);
                }
            }

            Console.WriteLine(dictionaryList.Count);
            return dictionaryList;
        }

    }
}
