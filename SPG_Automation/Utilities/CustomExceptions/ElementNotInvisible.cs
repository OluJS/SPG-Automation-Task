using System;

namespace SPG_Automation.Utilities.CustomExceptions
{
    public class ElementNotInvisible : Exception
    {
        public ElementNotInvisible(string msg) : base(msg)
        {

        }
    }
}
