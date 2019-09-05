using FileHelpers;

namespace RedirectGenerator
{
    [DelimitedRecord(",")]
    [IgnoreEmptyLines()]
    [IgnoreFirst]
    public class FailuresOutput
    {
        public string Url { get; set; }
    }
}