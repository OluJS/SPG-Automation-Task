using System;

namespace SPG_Automation.Utilities.CustomExceptions
{
    public class PageNotLoaded : Exception
    {
        public PageNotLoaded(string msg) : base(msg)
        {

        }
    }
}
