using System;

namespace RedirectGenerator
{
    public static class Helpers
    {
        /// <summary>
        /// Gets the domain information.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="stripWildCard">If to strip wildcard value</param>
        /// <returns>DomainInfo.</returns>
        public static DomainInfo GetDomainInfo(string url, bool stripWildCard = false)
        {
            var httpIndex = url.IndexOf("://", StringComparison.InvariantCultureIgnoreCase);

            var httpType = url.Substring(0, httpIndex);
            var mainUrl = url.Substring(httpIndex + 3);

            var pathSplitterIndex = mainUrl.IndexOf('/');

            string domain;
            string path;
            var queryString = string.Empty;

            if (pathSplitterIndex == -1)
            {
                domain = mainUrl.Substring(0);
                path = string.Empty;
            }
            else
            {
                domain = mainUrl.Substring(0, pathSplitterIndex);
                path = mainUrl.Substring(pathSplitterIndex + 1);
            }

            var domainQs = domain.IndexOf('?');
            var pathQs = path.IndexOf('?');

            if (domainQs != -1)
            {
                queryString = domain.Substring(domainQs + 1);
                domain = domain.Substring(0, domainQs);
            }

            if (pathQs != -1)
            {
                queryString = path.Substring(pathQs + 1);
                path = path.Substring(0, pathQs);
            }

            var pathEndsWithStar = path.EndsWith("*");

            if (pathEndsWithStar && stripWildCard)
            {
                path = path.TrimEnd('*');
            }

            return new DomainInfo
            {
                Domain = domain,
                HttpMode = httpType,
                Path = path,
                PathEndsWithStar = pathEndsWithStar,
                QueryString = queryString,
                HasQueryString = !string.IsNullOrEmpty(queryString),
                hasWww = domain.StartsWith("www"),
                IsSecure = httpType == "https"
            };
        }

        public static string CleanUrl(this string url)
        {
            var cleanUrl1 = url.Trim(',', '"').Replace("\\", "/").Replace("\"", "").Replace("&", "&amp;").Trim();
            var httpIndex = url.IndexOf("://", StringComparison.InvariantCultureIgnoreCase);

            if (httpIndex == -1 && !cleanUrl1.StartsWith("/"))
            {
                cleanUrl1 = "/" + cleanUrl1;
            }

            return cleanUrl1;
        }
    }
}