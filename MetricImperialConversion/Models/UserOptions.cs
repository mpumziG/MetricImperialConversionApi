using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MetricImperialConversionApi.Models
{
    public class UserOptions
    {
        [Display(Name = "Unit")]
        [Required]
        [RegularExpression(@"/^\d*\.?\d*$/", ErrorMessage = "You can only enter digits")]
        public double Units { get; set; }

        [Display(Name = "Convert to metric")]
        public bool ConvertFromMetricToImperial { get; set; }

        [Required]
        public MetricOptions MetricConversionType { get; set; }
        [Required]
        public ImperialOptions ImperialConversionType { get; set; }
    }

    public enum MetricOptions
    {
        Milimeter,
        Centimeter,
        Meter,
        Decameter,
        Hectometer,
        Kilometer
    }

    public enum ImperialOptions
    {
        Inch,
        Foot ,
        Yard,
        Mile
    }
}
