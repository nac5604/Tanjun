using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Tanjun
{
    public class TanjunProject
    {
        [XmlArray(ElementName = "Imports")] // Form DONE
        public List<string> Imports { get; set; }
        public List<string> ImportedHeaders { get; set; }

        [XmlArray(ElementName = "Model Settings")] // Form DONE
        public bool HasModel { get; set; }
        public bool HasAnimation { get; set; }

        [XmlArray(ElementName = "Basic Settings")] // Form DONE
        public string SpriteName { get; set; }
        public string SpriteProfileID { get; set; }
        public string SpriteID { get; set; }
        public string SpriteClassName { get; set; }
        public string SpriteBaseClassName { get; set; }
        public string SpriteARCNameList { get; set; }
        public string SpriteType { get; set; }

        [XmlArray(ElementName = "Collisions")] // Form DONE
        public List<string> Collisions { get; set; }
        public uint BitField2 { get; set; }

        [XmlArray(ElementName = "Sprite States")] // Form DONE
        public List<string> SpriteStates { get; set; }

        [XmlArray(ElementName = "Positioning and Categorization")]
        public int category1 { get; set; }
        public int category2 { get; set; }
        public decimal[] DistancesToCenter { get; set; } = new decimal[2];
        public decimal[] DistancesToEdge { get; set; } = new decimal[2];
        public decimal[] Scale { get; set; } = new decimal[3];

        [XmlArray(ElementName = "Annexation Spritedata")]
        public decimal[] Offsets { get; set; } = new decimal[2];
        public decimal[] aDistancesToCenter { get; set; } = new decimal[2];
        public uint[] aDistancesToEdge { get; set; } = new uint[2];
        public decimal _1C { get; set; }
        public decimal _1E { get; set; }
        public decimal _20 { get; set; }
        public decimal _22 { get; set; }
        public decimal Flags { get; set; }
    }
}
