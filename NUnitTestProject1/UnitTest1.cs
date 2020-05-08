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
            throw new System.Exception("NUnitTestProject1.Tests.Test1");
            ILogger<IndexModel> _logger = null;
            IndexModel indexModel = new IndexModel(_logger);
            indexModel.OnGet();
            Assert.Fail("Test 'Fail Test'");
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
            throw new System.Exception("NUnitTestProject1.MyTests.Test1");
            ILogger<IndexModel> _logger = null;
            IndexModel indexModel = new IndexModel(_logger);
            indexModel.OnGet();
            Assert.Fail("MyTests 'Fail Test'");
        }
    }
}