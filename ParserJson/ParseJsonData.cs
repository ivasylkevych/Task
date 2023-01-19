// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2022
// ----------------------------------------------------------------------

namespace ParserJson
{

    #region Usings

    using ConsoleTables;
    using Models.ParserJson;
    using System.Linq;
    using System.Net;

    #endregion

    /// <summary>
    /// The main class for JSON parser with the ParseJson method.
    /// </summary>
    public class ParseJsonData
    {
        /// <summary>
        /// Parsing JSON file.
        /// </summary>
        /// <param name="jsonString">
        /// The path to JSON file.
        /// </param>
        public void ParseJson(string jsonString)
        {
            var productsData = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductsData>(jsonString);
            var table = new ConsoleTable("Product name", "Category name");

            foreach (var product in productsData.Products.OrderBy(product => product.CategoryId))
            {
                foreach (var category in productsData.Categories.OrderBy(category => category.Id))
                {
                    if (product.CategoryId == category.Id)
                    {
                        table.AddRow(product.Name, category.Name);
                    }
                }
            }

            table.Write();
        }

        /// <summary>
        /// Gets JSON string from the website.
        /// </summary>
        /// <param name="url"></param>
        /// <returns>
        /// JSON string.
        /// </returns>
        public string GetJsonFromUrl(string url)
        {
            var json = new WebClient().DownloadString(url);
            return json;
        }
    }
}
