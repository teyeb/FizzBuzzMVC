using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzzMVC.Models;

namespace FizzBuzzMVC.Controllers
{
    public class FizzbuzzController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            FizzBuzzModel model = new();

            model.FirstNumber = 4;
            model.LastNumber = 7;

            return View(model);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(FizzBuzzModel model)
        {
            List<string> results = new List<string>();

            

            for(int i = 1; i <= 100; i++)
            {
                if(i%model.FirstNumber==0 && i%model.LastNumber== 0)
                {
                    //divisible by both fizz and buzz
                    results.Add("FizzBuzz");
                }
                else if(i%model.FirstNumber == 0)
                {
                    //divisible by only Fizz number only
                    results.Add("Fizz");
                }
                else if(i%model.LastNumber == 0)
                {
                    //divisible by only buzz only
                    results.Add("Buzz");
                }
                else
                {
                    //not divisible by either fizz or buzz
                    results.Add(i.ToString());
                }
            }

            model.Results = results;

            //Console.WriteLine(model.Results);
            
            return View(model);
        }




    }
}
