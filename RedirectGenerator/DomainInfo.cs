namespace RedirectGenerator
{
    public class DomainInfo
    {
        /// <summary>
        /// Gets or sets the HTTP mode.
        /// </summary>
        /// <value>The HTTP mode.</value>
        public string HttpMode { get; set; }

        /// <summary>
        /// Gets or sets the domain.
        /// </summary>
        /// <value>The domain.</value>
        public string Domain { get; set; }

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>The path.</value>
        public string Path { get; set; }

        public string QueryString { get; set; }

        public bool hasWww { get; set; }
        public bool IsSecure { get; set; }
        public bool HasQueryString { get; set; }
    }
}