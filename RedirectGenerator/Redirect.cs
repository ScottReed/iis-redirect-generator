namespace RedirectGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FileHelpers;

    [DelimitedRecord(",")]
    public class Redirect
    {
        [FieldQuoted()]
        public string OldUrl;

        [FieldQuoted()]
        public string NewUrl;
    }
}
