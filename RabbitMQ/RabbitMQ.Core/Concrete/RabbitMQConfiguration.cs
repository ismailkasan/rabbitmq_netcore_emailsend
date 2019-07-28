﻿using Microsoft.Extensions.Configuration;
using RabbitMQ.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.Core.Concrete
{
    public class RabbitMQConfiguration : IRabbitMQConfiguration
    {

        private readonly IConfiguration _config;
        public RabbitMQConfiguration()
        {
            _config = new ConfigurationBuilder().AddJsonFile("../appsettings.json", true, true).Build();
        }


        public string HostName => _config.GetSection("HostName").Value;


        public string UserName => _config.GetSection("UserName").Value;


        public string Password => _config.GetSection("Password").Value;
         
    }
}
