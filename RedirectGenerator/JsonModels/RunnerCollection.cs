using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace RedirectGenerator.JsonModels
{
    public class RunnerCollection
    {
        public string Name { get; set; }

        public RunnerResult[] Results { get; set; }
    }
}