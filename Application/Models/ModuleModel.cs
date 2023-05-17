using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Diagnostics;
using System.Media;
//using Android.OS;

namespace Glossa_App.Models
{
    internal class ModuleModel
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public DateTime Date { get; set; }
        public string TranslationLanguage { get; set; }
        public List<string> Words { get; set; }
        public Dictionary<string, List<string>> Translations { get; set; }
        public List<string> Audio { get; set; }
        public Dictionary<string, List<string>> Definitions { get; set; }

        public static ModuleModel ParseXml(string filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(filePath);
            

            ModuleModel sModule = new ModuleModel();

            XmlNode initNode = xmlDoc.SelectSingleNode("/gsmf/init");
            sModule.Author = initNode.SelectSingleNode("author").InnerText;
            sModule.Title = initNode.SelectSingleNode("title").InnerText;
            sModule.Language = initNode.SelectSingleNode("wlang").InnerText;
            sModule.Date = DateTime.Parse(initNode.SelectSingleNode("date").InnerText);

            XmlNode translationsNode = xmlDoc.SelectSingleNode("/gsmf/translations");
            sModule.TranslationLanguage = translationsNode.FirstChild.Name;

            sModule.Words = new List<string>();
            XmlNodeList wordsNodeList = xmlDoc.SelectNodes("/gsmf/wlist/word");
            foreach (XmlNode wordNode in wordsNodeList)
            {
                sModule.Words.Add(wordNode.InnerText);
            }

            sModule.Translations = new Dictionary<string, List<string>>();
            foreach (XmlNode translationNode in translationsNode.ChildNodes)
            {
                List<string> translations = new List<string>();
                XmlNodeList trNodeList = translationNode.ChildNodes;
                foreach (XmlNode trNode in trNodeList)
                {
                    translations.Add(trNode.InnerText);
                }
                sModule.Translations.Add(translationNode.Name, translations);
            }

            sModule.Audio = new List<string>();
            XmlNodeList audioNodeList = xmlDoc.SelectNodes("/gsmf/audio/spk");
            foreach (XmlNode audioNode in audioNodeList)
            {
                sModule.Audio.Add(audioNode.InnerText);
            }

            sModule.Definitions = new Dictionary<string, List<string>>();
            XmlNodeList wdblockNodeList = xmlDoc.SelectNodes("/gsmf/definitions/wdblock");
                int index = 0; // Индекс элемента в XmlNodeList
            foreach (XmlNode wdblockNode in wdblockNodeList)
            {
                List<string> definitions = new List<string>();
                XmlNodeList dfNodeList = wdblockNode.ChildNodes;
                foreach (XmlNode dfNode in dfNodeList)
                {
                    definitions.Add(dfNode.InnerText);
                }
                //sModule.Definitions.Add(sModule.Words[wdblockNodeList.IndexOf(wdblockNode)], definitions);
                //foreach (XmlNode wdblock in wdblockNodeList)
                //{
                //    if (wordNode.InnerText == sModule.Words[index])
                //    {
                //        break; // Найден соответствующий элемент
                //    }
                //    index++;
                //}
                //Debug.WriteLine(sModule.Words[index]);
                sModule.Definitions.Add(sModule.Words[index], definitions);
                index++;
            }

            return sModule;
        }

        
    }
}
