using Microsoft.AspNetCore.Mvc.Razor;
using System.Collections.Generic;
using JetBrains.Annotations;

[assembly: AspMvcViewLocationFormat("/Features/{1}/{0}.cshtml")]
[assembly: AspMvcViewLocationFormat("/Features/Shared/{0}.cshtml")]
namespace DotNetCore.Web.Infrastructure
{
    public class FeatureLocationExpander : IViewLocationExpander
    {
        public void PopulateValues(ViewLocationExpanderContext context)
        {
            
        }

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            return new[] { "/Features/{1}/{0}.cshtml", "/Features/Shared/{0}.cshtml" };
        }
    }
}
