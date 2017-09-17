using System;

namespace DotNetCore.Web.Core
{
    public class HelperClass
    {
        public string GetTestValue(string input)
        {
            return $"Test from Web.Core: {input}";
        }
    }
}
