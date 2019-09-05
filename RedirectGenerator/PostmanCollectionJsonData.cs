using System.Collections.Generic;

namespace RedirectGenerator
{
    /// <summary>
    /// Class PostmanCollectionJsonData.
    /// </summary>
    public class PostmanCollectionJsonData
    {
        /// <summary>
        /// Gets or sets the name of the collection.
        /// </summary>
        /// <value>The name of the collection.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        /// <value>The unique identifier.</value>
        public string Guid { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public IEnumerable<PostmanCollectionItemJsonData> Items { get; set; }
    }
}