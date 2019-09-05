namespace RedirectGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FileHelpers;

    /// <summary>
    /// The row item for the chain redirects sheet
    /// </summary>
    [DelimitedRecord(",")]
    public class ChainRedirectRow
    {
        /// <summary>
        /// The source URL which is being redirected
        /// </summary>
        [FieldQuoted(QuoteMode.OptionalForBoth)]
        public string Source;

        /// <summary>
        /// The first redirect that the source URL goes to
        /// </summary>
        [FieldQuoted(QuoteMode.OptionalForBoth)]
        public string Redirect;

        /// <summary>
        /// The second redirect that the first redirect goes to
        /// </summary>
        [FieldQuoted(QuoteMode.OptionalForBoth)]
        public string Final;
    }
}
