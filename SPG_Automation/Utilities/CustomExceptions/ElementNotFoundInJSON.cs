using System;

namespace SPG_Automation.Utilities.CustomExceptions
{
    public class ElementNotFoundInJSON : Exception
    {
        public ElementNotFoundInJSON(string msg) : base(msg)
        {

        }
    }
}
