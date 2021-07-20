using Flurl.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDrawer.Helpers;
using WebDrawer.Models;

namespace WebDrawer.Data
{
    public class PokemonData
    {
        public PokemonData()
        {

        }

        public async Task<PokemonModel> PokemonModels(string number)
        {
            try
            {

                var url = Endpoints.PokemonUrl + number.ToString();

                // Fill object.
                var result = await url.GetStringAsync();
                var resultObj = JsonConvert.DeserializeObject<PokemonModel>(result);

                return resultObj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
