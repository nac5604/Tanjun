using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Tanjun
{
    [Serializable]
    public class TanjunProject
    {
        [Serializable]
        public struct CoordPair
        {
            public decimal x;
            public decimal y;
        }
        [Serializable]
        public struct Scale
        {
            public decimal x;
            public decimal y;
            public decimal z;
        }
        [Serializable]
        public struct ReplacementSprite
        {
            public CoordPair distancesToCenter;
            public CoordPair distancesToEdge;
            public Scale scale;
        }
        [Serializable]
        public struct NewSprite
        {
            public CoordPair offsets;
            public CoordPair distancesToCenter;
            public CoordPair distancesToEdge;
            public int _1C;
            public int _1E;
            public int _20;
            public int _22;
            public int flags;
        }
        [Serializable]
        public struct HeaderData
        {
            public string headerName;
            public string type;
            public bool imported;
        }
        // Imports
        public List<HeaderData> imports { get; set; }

        // Model Settings
        public bool spriteHasModel { get; set; }
        public bool spriteHasAnimation { get; set; }
        public string modelARCName { get; set; }
        public string modelBRRESName { get; set; }
        public string modelMDL0Name { get; set; }
        public string modelCHR0Name { get; set; }

        // Basic Settings
        public string spriteName { get; set; }
        public string spriteProfileID { get; set; }
        public string spriteID { get; set; }
        public string spriteClassName { get; set; }
        public string spriteBaseClassName { get; set; }
        public string spriteARCNameList { get; set; }
        public int spriteType { get; set; }

        // Collisions
        public List<string> collisions { get; set; }
        public string bitField2 { get; set; }

        // Sprite states
        public List<string> spriteStates { get; set; }

        // Pos and Categorization
        public int category1 { get; set; }
        public int category2 { get; set; }
        public string spriteLightmapType { get; set; }
        
        // Spritedata

        public ReplacementSprite replacementSprite = new ReplacementSprite();
        public NewSprite newSprite = new NewSprite();
    }
}
