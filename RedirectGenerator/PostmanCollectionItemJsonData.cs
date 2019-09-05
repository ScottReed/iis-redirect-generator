using System.Collections.Generic;

namespace RedirectGenerator
{
    /// <summary>
    /// Class PostmanCollectionItemJsonData.
    /// </summary>
    public class PostmanCollectionItemJsonData
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        /// <value>The unique identifier.</value>
        public string Guid { get; set; }

        /// <summary>
        /// Gets or sets the status code.
        /// </summary>
        /// <value>The status code.</value>
        public string StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the full to URL.
        /// </summary>
        /// <value>The full to URL.</value>
        public string FullToUrl { get; set; }

        /// <summary>
        /// Gets or sets the full from URL.
        /// </summary>
        /// <value>The full from URL.</value>
        public string FullFromUrl { get; set; }

        /// <summary>
        /// Gets or sets the protocol.
        /// </summary>
        /// <value>The protocol.</value>
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets the hosts.
        /// </summary>
        /// <value>The hosts.</value>
        public IEnumerable<string> Hosts { get; set; }

        /// <summary>
        /// Gets or sets the paths.
        /// </summary>
        /// <value>The paths.</value>
        public IEnumerable<string> Paths { get; set; }
    }
}