using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Objects
{
    public class RollObj
    {
        string Name;
        string RollString;
        string Description;

        public RollObj(string name, string rollString, string description)
        {
            Name = name;
            RollString = rollString;
            Description = description;
        }
    }
}
