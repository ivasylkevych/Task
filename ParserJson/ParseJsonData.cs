// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2022
// ----------------------------------------------------------------------

namespace ParserJson
{

    #region Usings

    using ConsoleTables;
    using ParserJson.Models;
    using System;
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
            var sortedCategories = productsData.Categories.OrderBy(category => category.Id).ToArray();

            foreach (var product in productsData.Products)
            {
                var categoryIndex = Array.BinarySearch(sortedCategories.Select(category => category.Id).ToArray(), product.CategoryId);
                table.AddRow(product.Name, sortedCategories[categoryIndex].Name);
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
