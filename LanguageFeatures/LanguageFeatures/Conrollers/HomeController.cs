using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Conrollers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var results = new List<string>();

            foreach (var p in Product.GetProducts())
            {
                var name = p?.Name ?? "<No Name>";
                var price = p?.Price ?? 0;
                var relatedName = p?.Related?.Name ?? "<None>";

                results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
            }
            return View(results);
        }
    }
}
