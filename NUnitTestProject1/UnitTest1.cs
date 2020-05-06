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
            ILogger<IndexModel> _logger = null;
            IndexModel indexModel = new IndexModel(_logger);
            indexModel.OnGet();
            Assert.Pass();
        }
    }
}