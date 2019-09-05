using System;

namespace RedirectGenerator
{
    public static class Helpers
    {
        /// <summary>
        /// Gets the domain information.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>DomainInfo.</returns>
        public static DomainInfo GetDomainInfo(string url)
        {
            var httpIndex = url.IndexOf("://", StringComparison.InvariantCultureIgnoreCase);
            var httpType = url.Substring(0, httpIndex);
            var mainUrl = url.Substring(httpIndex + 3);

            var pathSplitter = mainUrl.IndexOf('/');
            var domain = mainUrl.Substring(0, pathSplitter);
            var path = mainUrl.Substring(pathSplitter + 1);

            return new DomainInfo
            {
                Domain = domain,
                HttpMode = httpType,
                Path = path
            };
        }
    }
}