using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebDrawer.Data;
using WebDrawer.Models;

namespace WebDrawer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private PokemonData pokemonData;
        private PokemonModel PokemonModel;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            // pokemonData
            pokemonData = new PokemonData();
            PokemonModel = new PokemonModel();
        }

        public IActionResult Index()
        {
            // Get.
            GetData();

            // Set data.
            ViewBag.PokemonObjectModel = PokemonModel;

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

        private async void GetData()
        {
            try
            {
                PokemonModel = await pokemonData.PokemonModels();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
