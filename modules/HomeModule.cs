// using Nancy;
// using LeetSpeakNS.Objects;
// using System.Collections.Generic;
//
// namespace LeetSpeakNS
// {
//   public class HomeModule : NancyModule
//   {
//     public HomeModule()
//     {
//       Get["/"] = _ => {
//         return View["translate.cshtml", ""];
//       };
//       Post["/leetspeak"] = _ => {
//         return View["translate.cshtml", LeetSpeak.Translate(Request.Form["english"])];
//       };
//     }
//   }
// }
