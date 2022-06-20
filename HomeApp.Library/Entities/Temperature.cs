using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApp.Library.Entities
{
    public class Temperature
    {
        public DateTime Id { get; set; }
        public float Value { get; set; }

        public DateTime Timestamp => Id;
    }

    public class TemperatureDto
    {
        public DateTime Id { get; set; }
        public float Value { get; set; }
    }

    public static partial class Extensions 
    {
        public static TemperatureDto ToDto(this Temperature x) 
        {
            return new TemperatureDto
            {
                Id = x.Id,
                Value = x.Value
            };
        }
    }
}
