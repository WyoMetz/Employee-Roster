using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemonstration
{
    public class InputValidation
    {
        public bool Invalid { get; private set; }

        public int Int(string value)
        {
            try
            {
                int CheckValue = int.Parse(value);
                Invalid = false;
                return CheckValue;
            }
            catch
            {
                Invalid = true;
                return 0;
            }
        }

        public string String(string value)
        {
            try
            {
                int CheckValue = int.Parse(value);
                Invalid = true;
                return "String cannot be a number";
            }
            catch
            {
                Invalid = false;
                return value;
            }
        }
    }
}
