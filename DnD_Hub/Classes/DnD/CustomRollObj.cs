using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Rolls
{
    public class CustomRoll
    {
        public struct RollParameters
        {
            public string RollName;
            public string RollString;
            public int Level;
            public string Description;
        }
        public string RollName { get; set; }
        public string RollString { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }

        public CustomRoll(string rollName, string rollString, int level, string description)
        {
            RollName    = rollName;
            RollString  = rollString;
            Level       = level;
            Description = description;
        }

        public CustomRoll(RollParameters parameters)
        {
            RollName    = parameters.RollName;
            RollString  = parameters.RollString;
            Level       = parameters.Level;
            Description = parameters.Description;
        }

        public CustomRoll()
        { }
    }
}
