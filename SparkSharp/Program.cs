﻿using System;
using System.Configuration;

namespace SparkSharp
{
    static class Program
    {
        static void Main()
        {
            ApplicationSettings.SetupSettings();

            var settings = ConfigurationManager.AppSettings;

            Console.WriteLine(settings["AutoStartExample"]);

            switch (settings["AutoStartExample"])
            {
                case nameof(CosmosPoolingBaseQueryLoadTestExample):
                    CosmosPoolingBaseQueryLoadTestExample.ExampleAsync(settings).GetAwaiter().GetResult();
                    break;
                case nameof(CosmosBaseQueryExample):
                    CosmosBaseQueryExample.ExampleAsync(settings).GetAwaiter().GetResult();
                    break;
                case nameof(CosmosPoolingExample):
                    CosmosPoolingExample.ExampleAsync(settings).GetAwaiter().GetResult();
                    break;
                case nameof(CosmosPoolingBaseQueryExample):
                    CosmosPoolingBaseQueryExample.ExampleAsync(settings).GetAwaiter().GetResult();
                    break;
                case nameof(CosmosExample):
                    CosmosExample.ExampleAsync(settings).GetAwaiter().GetResult();
                    break;
                default:
                    SimpleExample.ExampleAsync(settings).GetAwaiter().GetResult();
                    break;
            }
        }
    }
}
