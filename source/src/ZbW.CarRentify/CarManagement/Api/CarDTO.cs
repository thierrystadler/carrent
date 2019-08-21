using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZbW.CarRentify.CarManagement.Api
{
    public class CarDTO
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        public Guid Id { get; internal set; }
        public string Model { get; internal set; }
        public string Brand { get; internal set; }
    }
}
