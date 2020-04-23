using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rozdz_5;
using Rozdz_5.Services;

namespace Rozdz5Tests
{
    [TestClass]
    public class ContainerTests
    {
        [TestMethod]
        public void Can_Resolve_Types()
        {
            var container = new Container();

            container.For<ILogger>().Use<SqlServerLogger>();

            var logger = container.Resolve<ILogger>();

            Assert.AreEqual(typeof(SqlServerLogger), logger.GetType());
        }
    }
}
