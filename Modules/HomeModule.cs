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

            Post["/Count"] = _ =>
            {
                RepeatCounter newCounter = new RepeatCounter(Request.Form["word"], Request.Form["sentence"]);
                return View["results.cshtml", newCounter];
            };
        }
    }
}
