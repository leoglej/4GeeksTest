using InventoryShoes.Models;
using InventoryShoes.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InventoryShoes.Controllers.Api
{
    public class StoresController : ApiController
    {
        
        StoreModel[] stores = new StoreModel[]
        {
            new StoreModel(){Id=0,Name="AllShoes",Address="El Cajon 2231"},
            new StoreModel(){Id=1,Name="CheaperShoes",Address="San Diego 4565"},
            new StoreModel(){Id=2,Name="BestShoes",Address="San Ysidro 1111"}
        };

        // GET: services/Store
        [BasicAuthentication]
        public string Get()
        {
            var count = stores.Length;

            string res = @"{""stores"":" + System.Web.Helpers.Json.Encode(stores) + @",""success"":true" + @",""total_elements"":" + count.ToString() + "}";
            
            return res;
        }

      }
}
