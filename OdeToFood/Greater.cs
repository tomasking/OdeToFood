using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace OdeToFood
{
    public interface IGreater
    {
        string GetGreeting();
    }

    public class Greater : IGreater
    {
        private readonly IConfiguration _configuration;

        public Greater(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetGreeting()
        {
            return "Hello from greater!" + _configuration["Greeting"];
        }
    }
}
