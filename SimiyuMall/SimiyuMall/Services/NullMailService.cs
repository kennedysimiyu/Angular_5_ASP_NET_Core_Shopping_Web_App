using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimiyuMall.Services
{
    // a null mail service class to help as test our mail service
    public class NullMailService : IMailService
    {
        private readonly ILogger<NullMailService> _logger;

        // injecting a logger service
        public NullMailService(ILogger<NullMailService> logger)
        {
            _logger = logger; 

        }

        public void SendMessage(string to, string subject, string body)
        {
            // log message
            _logger.LogInformation($"To: {to} Subject: {subject} Body: {body}");
        }
    }
}
