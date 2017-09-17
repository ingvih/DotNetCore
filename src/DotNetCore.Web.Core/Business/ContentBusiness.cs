using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCore.Web.Core.Business
{
    public class ContentBusiness : IContentBusiness
    {
        public string GetTestContent(string input)
        {
            return $"Test from ContentBusiness: {input}";
        }
    }
}
