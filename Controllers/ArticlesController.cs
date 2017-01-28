using InventoryShoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InventoryShoes.Controllers
{
    public class ArticlesController : ApiController
    {

        ArticleModel[] articles = new ArticleModel[]
        {
            new ArticleModel(){Id=0,Name="Adidas",Description="Sports Shoes", Price=10.50F, StoreId=0, TotalInShelf=5, TotalInVault= 2},
            new ArticleModel(){Id=1,Name="Falabellas",Description="School Shoes", Price=20.50F, StoreId=0, TotalInShelf=5, TotalInVault= 3},
            new ArticleModel(){Id=2,Name="Andrea",Description="Casual Shoes", Price=30.50F, StoreId=0, TotalInShelf=5, TotalInVault= 4},
            new ArticleModel(){Id=3,Name="Adidas",Description="Sports Shoes", Price=1.50F, StoreId=1, TotalInShelf=5, TotalInVault= 2},
            new ArticleModel(){Id=4,Name="Falabellas",Description="School Shoes", Price=2.50F, StoreId=1, TotalInShelf=5, TotalInVault= 3},
            new ArticleModel(){Id=5,Name="Andrea",Description="Casual Shoes", Price=3.50F, StoreId=1, TotalInShelf=5, TotalInVault= 4},
            new ArticleModel(){Id=6,Name="Adidas",Description="Sports Shoes", Price=100.50F, StoreId=2, TotalInShelf=5, TotalInVault= 2},
            new ArticleModel(){Id=7,Name="Falabellas",Description="School Shoes", Price=200.50F, StoreId=2, TotalInShelf=5, TotalInVault= 3},
            new ArticleModel(){Id=8,Name="Andrea",Description="Casual Shoes", Price=300.50F, StoreId=2, TotalInShelf=5, TotalInVault= 4},
        };


        // GET: api/Article
        public string Get()
        {

            var count = articles.Length;

            string res = @"{""articles"":" + System.Web.Helpers.Json.Encode(articles) + @",""success"":true" + @",""total_elements"":" + count.ToString() + "}";

            return res;

        }

        [HttpGet]
        public string stores(string id)
        {
            int numVal;
            string res = string.Empty;

            if (Int32.TryParse(id, out numVal))
            {

                var article = from a in articles where a.StoreId == numVal select a;

                var count = article.Count();

                if (count == 0)
                {
                    throw new HttpResponseException(HttpStatusCode.NotFound);

                }
                else
                {

                    res = @"{""articles"":" + System.Web.Helpers.Json.Encode(article) + @",""success"":true" + @",""total_elements"":" + count.ToString() + "}";

                }

            }
            else
            {

                throw new HttpResponseException(HttpStatusCode.BadRequest);

            }

            return res;

        }  
        
     }

}
