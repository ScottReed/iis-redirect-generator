using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RedirectGenerator
{
    /// <summary>
    /// Class PostmanGenerator.
    /// </summary>
    public static class PostmanGenerator
    {
        public static string CollectionJson { get; private set; }
        public static string ItemJson { get; private set; }

        /// <summary>
        /// Loads this instance.
        /// </summary>
        public static void Load()
        {
            LoadCollectionJson();
            LoadItemJson();
        }

        /// <summary>
        /// Loads the collection json.
        /// </summary>
        private static void LoadCollectionJson()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "example.postman_collection.json");
            CollectionJson = File.ReadAllText(path);
        }

        /// <summary>
        /// Loads the item json.
        /// </summary>
        private static void LoadItemJson()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "example.item.json");
            ItemJson = File.ReadAllText(path);
        }

        public static string GetCollectionJson(PostmanCollectionJsonData data)
        {
            if (!string.IsNullOrWhiteSpace(CollectionJson) && !string.IsNullOrWhiteSpace(ItemJson))
            {
                var itemStringBuilderList = new List<string>();

                foreach (var postmanCollectionItemJsonData in data.Items)
                {
                    var item = string.Copy(ItemJson);

                    var hosts = GetArrayAsJson(postmanCollectionItemJsonData.Hosts);
                    var paths = GetArrayAsJson(postmanCollectionItemJsonData.Paths);

                    item = item.Replace("{NAME}", postmanCollectionItemJsonData.Name);
                    item = item.Replace("{GUID}", postmanCollectionItemJsonData.Guid);
                    item = item.Replace("{STATUSCODE}", postmanCollectionItemJsonData.StatusCode);
                    item = item.Replace("{FULLTOURL}", postmanCollectionItemJsonData.FullToUrl);
                    item = item.Replace("{FULLFROMUL}", postmanCollectionItemJsonData.FullFromUrl);
                    item = item.Replace("{PROTOCOL}", postmanCollectionItemJsonData.Protocol);
                    item = item.Replace("{HOSTS}", hosts);
                    item = item.Replace("{PATHS}", paths);

                    itemStringBuilderList.Add(item);
                }

                var itemsString = string.Join(",", itemStringBuilderList);
                var collectionString = string.Copy(CollectionJson);

                collectionString = collectionString.Replace("{NAME}", data.Name);
                collectionString = collectionString.Replace("{GUID}", data.Guid);
                collectionString = collectionString.Replace("{ITEMS}", itemsString);

                return collectionString;
            }

            return string.Empty;
        }

        /// <summary>
        /// Gets the array as json.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns>System.String.</returns>
        private static string GetArrayAsJson(IEnumerable<string> values)
        {
            return "\"" + string.Join("\",\"", values) + "\"";
        }
    }
}