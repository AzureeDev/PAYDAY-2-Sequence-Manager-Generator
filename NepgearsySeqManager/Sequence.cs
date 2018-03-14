using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.XPath;

namespace NepgearsySeqManager
{
    class Sequence
    {
        public static XDocument XMLSequence;

        public static string local_path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public static string temp_file_name = "temp_file_xml.xml";
        public static string combined_path = Path.Combine(local_path, temp_file_name);

        public void Init()
        {
            CreateTempFile();
        }

        public static void CreateTempFile()
        {
            XMLSequence = 
                new XDocument(
                    new XDeclaration("1.0", Encoding.UTF8.HeaderName, String.Empty),
                    new XComment("Generated with PAYDAY 2: Sequence Manager Generator"),
                    new XElement("table", new XElement("unit"))
            );

            Save();
        }

        public static void DeleteTempFile()
        {
            File.Delete(combined_path);
        }

        public void AddMainSequenceInfos(string name, bool is_editable, bool is_triggable)
        {
            var Root = XMLSequence.Root.Element("unit");

            Root.AddFirst(
                new XElement("sequence",
                    new XAttribute("editable_state", is_editable.ToString().ToLower()),
                    new XAttribute("triggable", is_triggable.ToString().ToLower()),
                    new XAttribute("name", "'" + name + "'")
                )
            );
        }

        public void AddMaterialConfigSequence(string material_config)
        {
            var Root = XMLSequence.Root.Element("unit").Element("sequence");

            Root.Add(
                new XElement("material_config",
                    new XAttribute("name", "'" + material_config + "'")
                )
            );
        }

        public void AddSoundSequence(string action, string sound_event, string sound_object)
        {
            var Root = XMLSequence.Root.Element("unit").Element("sequence");

            Root.Add(
                new XElement("sound",
                    new XAttribute("action", "'" + action + "'"),
                    new XAttribute("event", "'" + sound_event + "'"),
                    new XAttribute("object", "'" + sound_object + "'")
                )
            );
        }

        public void AddObjectSequence(bool enabled, string name)
        {
            var Root = XMLSequence.Root.Element("unit").Element("sequence");

            Root.Add(
                new XElement("object",
                    new XAttribute("enabled", enabled.ToString().ToLower()),
                    new XAttribute("name", "'" + name + "'")
                )
            );
        }

        public static void Save()
        {
            XMLSequence.Save(combined_path);
        }
    }
}
