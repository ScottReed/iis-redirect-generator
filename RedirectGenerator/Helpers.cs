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

            string httpType;
            string domain;
            string path;
            var queryString = string.Empty;

            // Does the URL start with HTTP/HTTPS prefix (://)
            if (httpIndex == -1)
            {
                httpType = string.Empty;
                domain = string.Empty;
                path = url;
            }
            else
            {
                httpType = url.Substring(0, httpIndex);
                var mainUrl = url.Substring(httpIndex + 3);    

                var pathSplitterIndex = mainUrl.IndexOf('/');

                if (pathSplitterIndex == -1)
                {
                    domain = mainUrl;
                    path = string.Empty;
                }
                else
                {
                    domain = mainUrl.Substring(0, pathSplitterIndex);
                    path = mainUrl.Substring(pathSplitterIndex + 1);
                }

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

            if (path.StartsWith("/"))
            {
                path = path.TrimStart('/');
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

        public static string CleanUrl(this string url, bool isLinux)
        {
            var cleanUrl1 = url.Trim(',', '"').Replace("\\", "/").Replace("\"", "").Replace("&", "&amp;").Trim();

            if (isLinux)
            {
                cleanUrl1 = cleanUrl1.Replace(" ", "%20");
            }

            var httpIndex = url.IndexOf("://", StringComparison.InvariantCultureIgnoreCase);

            if (httpIndex == -1 && !cleanUrl1.StartsWith("/"))
            {
                cleanUrl1 = "/" + cleanUrl1;
            }

            return cleanUrl1;
        }
    }
}