using Nancy;
using WordCounter.Objects;
using System.Collections.Generic;
using System;

namespace WordCounter
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {
                return View["index.cshtml"];
            };


        }
    }
}
