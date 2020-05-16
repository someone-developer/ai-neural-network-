using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_EstimateManday.Models
{
   public class MandayDataSet
    {
        [JsonProperty("Inputs")]
        public List<double> Inputs { get; set; }
        [JsonProperty("Output")]
        public int Output { get; set; }
    }
}
