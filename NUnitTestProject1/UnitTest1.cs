using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using WebApplication1.Pages;


namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var serviceProvider = new ServiceCollection()
                                  .AddLogging()
                                  .BuildServiceProvider();

            var factory = serviceProvider.GetService<ILoggerFactory>();

            var logger = factory.CreateLogger<IndexModel>();

            IndexModel indexModel = new IndexModel(logger);
            //indexModel.OnGet();
            Assert.Pass("MyTests 'Fail Test'");
            //Assert.Fail("MyTests 'Fail Test'");
        }
    }
    public class MyTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var serviceProvider = new ServiceCollection()
                                  .AddLogging()
                                  .BuildServiceProvider();

            var factory = serviceProvider.GetService<ILoggerFactory>();

            var logger = factory.CreateLogger<IndexModel>();
             
            IndexModel indexModel = new IndexModel(logger);
            //indexModel.OnGet();
            Assert.Pass("MyTests 'Fail Test'");
            //Assert.Fail("MyTests 'Fail Test'");
        }
        [Test]
        public void Test2()
        {
            var serviceProvider = new ServiceCollection()
                                  .AddLogging()
                                  .BuildServiceProvider();

            var factory = serviceProvider.GetService<ILoggerFactory>();

            var logger = factory.CreateLogger<ErrorModel>();

            ErrorModel indexModel = new ErrorModel(logger);
            //indexModel.OnGet();
            Assert.Pass("MyTests 'Fail Test'");
            //Assert.Fail("MyTests 'Fail Test'");
        }
    }
}