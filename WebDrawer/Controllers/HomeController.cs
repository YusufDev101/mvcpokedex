using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using WebDrawer.Data;
using WebDrawer.Models;

namespace WebDrawer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private PokemonData pokemonData;
        private PokemonModel PokemonModel;
        private List<PokemonModel> PokemonModels;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            // pokemonData
            pokemonData = new PokemonData();
            PokemonModel = new PokemonModel();
            PokemonModels = new List<PokemonModel>();
        }

        public IActionResult Index()
        {
            // Get.
            GetData();

            // Set data.
            ViewBag.PokemonObjectModel = PokemonModels;

            // Return.
            return View();
        }

        public IActionResult Index(string submitButton)
        {

            switch (submitButton)
            {
                case "Send":
                    Console.WriteLine();
                    break;
                case "Cancel":
                    break;
                default:
                    break;
            }


            // Return.
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private void GetData()
        {
            try
            {
                for (int i = 1; i < 25; i++)
                {
                    PokemonModel = pokemonData.PokemonModels(i.ToString()).Result;

                    PokemonModels.Add(PokemonModel);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
