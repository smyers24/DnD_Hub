using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Hub
{
    class roll
    {
        string name;
        string textField;

        public void CustomRoll (string name, string textField)
        {
            this.name = name;
            this.textField = textField;
        }
    }
}
