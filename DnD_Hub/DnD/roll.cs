using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Hub
{
    class RollFunctions
    {
        string name;
        string textField;

        Random rollSeed = new Random();

        public void CustomRoll (string name, string textField)
        {
            this.name = name;
            this.textField = textField;
        }

        public int rollCalc(string qty, int dieValue, string mod)
        {
            int rollQuantity, rollQty, modValue;
            bool validRollQty = int.TryParse(qty, out rollQty);

            if (validRollQty)
                rollQuantity = rollQty;
            else
                rollQuantity = 1;
            int result = roll(rollQuantity, dieValue);
            if (!string.IsNullOrEmpty(qty))
            {
                int.TryParse(mod, out modValue);
                result += modValue;
            }
            return result;
        }

        public int roll(int numberOfRolls, int dieValue)
        {

            int result = 0;
            for (int i = 0; i < numberOfRolls; i++)
            {
                result += rollSeed.Next(1, dieValue + 1);
            }
            Console.WriteLine(result);
            return result;

        }
    }
}
