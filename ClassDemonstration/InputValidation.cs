using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemonstration
{
    public class InputValidation
    {
        public bool InputInvalid { get; private set; }

        public int Int(string value)
        {
            try
            {
                int CheckValue = int.Parse(value);
                InputInvalid = false;
                return CheckValue;
            }
            catch
            {
                InputInvalid = true;
                return 0;
            }
        }

        public string String(string value)
        {
            try
            {
                int CheckValue = int.Parse(value);
                InputInvalid = true;
                return "String cannot be a number";
            }
            catch
            {
                InputInvalid = false;
                return value;
            }
        }
    }
}
