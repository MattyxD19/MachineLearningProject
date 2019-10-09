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
                //since since a word might be repeated it is filtered out
                if (dictionaryList.Contains(musicWord))
                {

                    Console.WriteLine("\n");
                }
                //if the word isnt inside the list then it is added after it has been stemmed
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
