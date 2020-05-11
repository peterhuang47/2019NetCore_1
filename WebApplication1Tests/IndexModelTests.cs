using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Pages.Tests
{
    [TestClass()]
    public class IndexModelTests
    {
        [TestMethod()]
        public void OnGetTest()
        {
            var serviceProvider = new ServiceCollection()
                                  .AddLogging()
                                  .BuildServiceProvider();

            var factory = serviceProvider.GetService<ILoggerFactory>();

            var logger = factory.CreateLogger<IndexModel>();

            IndexModel indexModel = new IndexModel(logger);
            indexModel.OnGet();
            //Assert.Fail("MyTests 'Fail Test'"); 
        }
        [TestMethod()]
        public void OnGetTest2()
        {
            var serviceProvider = new ServiceCollection()
                                  .AddLogging()
                                  .BuildServiceProvider();

            var factory = serviceProvider.GetService<ILoggerFactory>();

            var logger = factory.CreateLogger<ErrorModel>();

            ErrorModel indexModel = new ErrorModel(logger);
            indexModel.OnGet();
            //Assert.Fail("MyTests 'Fail Test'"); 
        }
    }
}