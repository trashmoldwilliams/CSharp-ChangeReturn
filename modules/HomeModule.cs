using Nancy;
using AnagramNS.Objects;
using System.Collections.Generic;

namespace AnagramModule
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
       List<string> inputString = Word.GetWordList();
        return View["index.cshtml", inputString];
      };

      Post["/updatePage"] = _ =>
      {
        string input = Request.Form["inputWord"];
        List<string> output = Word.CompareWord(input);
        return View ["matchedWords.cshtml", output];
      };

    }
  }
}
