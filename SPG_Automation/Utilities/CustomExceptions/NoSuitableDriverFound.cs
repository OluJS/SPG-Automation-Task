using System;

namespace SPG_Automation.Utilities.CustomExceptions
{
    public class NoSuitableDriverFound : Exception
    {
        public NoSuitableDriverFound(string msg) : base(msg)
        {

        }
    }
}
