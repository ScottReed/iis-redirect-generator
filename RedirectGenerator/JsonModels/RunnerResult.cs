using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RedirectGenerator.JsonModels
{
    public class RunnerResult
    {
        public string Name { get; set; }

        public JToken TestPassFailCounts { get; set; }

        [JsonIgnore]
        public bool HasPassed => TestPassFailCounts.ToString().Contains("\"fail\": 0");
    }
}