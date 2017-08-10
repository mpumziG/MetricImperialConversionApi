using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MetricImperialConversion.Domain;
using MetricImperialConversionApi.Models;
using System.Net.Http;
using System.Net.Http.Formatting;


namespace MetricImperialConversion.Controllers
{
    [Route("api/[controller]")]
    public class ConversionController : Controller
    {
        

        // GET api/values
        [HttpGet]
        [Produces(typeof(string))]
        public async Task<string> DoConversion([FromQuery]UserOptions model)
        {
            double result = 0;
            
            //if (ModelState.IsValid)
            //{
                var s = await Task.FromResult<IActionResult>(null);  // .ReadAsStreamAsync().Result.Seek(0, System.IO.SeekOrigin.Begin);
                if (model.ConvertFromMetricToImperial)
                {
                    result = ConvertToImperial(model.Units, model.ImperialConversionType.ToString());
                }
                else
                {
                    result = ConvertToMetric(model.Units, model.MetricConversionType.ToString());
                }
            //}
            return result.ToString();

        }

        private double ConvertToImperial(double units, string conversionType)
        {
            double result = 0;
           
       
            var imperial = new Imperial(units);
               
            switch (conversionType)
            {

                case "Inch":
                    result = imperial.ToInches();
                    break;
                case "Foot":
                    result = imperial.ToFeet();
                    break;
                case "Yard":
                     result = imperial.ToYards();
                    break;
                case "Mile":
                    result = imperial.ToMiles();
                    break;
            }
            
            return result;     
        }
       
        private double ConvertToMetric(double units, string conversionType)
        {
            var metric = new Metric(units);
            double result = 0;
            switch (conversionType)
            {

                case "Milimeter":
                    result = metric.ToMeters();
                    break;
                case "Centimeter":
                    result = metric.ToCentimeters();
                    break;
                case "Meter":
                    result = metric.ToMeters();
                    break;
                case "Decameter":
                    result = metric.ToDecameters();
                    break;

                case "Hectometer":
                    result = metric.ToHectometers();
                    break;
                case "Kilometer":
                    result = metric.ToKilometers();
                    break;
            }
            return result;
        }
        
    }
}
