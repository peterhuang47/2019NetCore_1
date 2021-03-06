﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string Now { get; set; }
        public string Message { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            System.Diagnostics.Trace.TraceInformation("-------TraceInformation");
            System.Diagnostics.Trace.TraceError("------TraceError");
            System.Diagnostics.Trace.WriteLine("------WriteLine");
            System.Diagnostics.Trace.TraceWarning("------TraceWarning");
            Console.WriteLine("Hello World!");

            string secretName = "ManualMySecretName1";

            //string keyVaultName = Environment.GetEnvironmentVariable("KEY_VAULT_NAME");
            string keyVaultName = "webappkeyvaulttest1";
            var kvUri = "https://" + keyVaultName + ".vault.azure.net";

            var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential( ));
              
            Console.WriteLine("Retrieving your secret from " + keyVaultName + ".");

            KeyVaultSecret secret = client.GetSecret(secretName);

            Console.WriteLine("Your secret is '" + secret.Value + "'.");


            Now = "Your secret is '" + secret.Value + "'." + "Your secret is '" + secret.Value + "'."; 
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine(" done.");

        }
    }
}
