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

        [TestMethod]
        public void Can_Resolve_Types_Without_DefaultConstructor()
        {
            var container = new Container();

            container.For<ILogger>().Use<SqlServerLogger>();
            container.For<IRepository<Car>>().Use<SqlRepository<Car>>();

            var repository = container.Resolve<IRepository<Car>>();

            Assert.AreEqual(typeof(SqlRepository<Car>), repository.GetType());
        }

        [TestMethod]
        public void Can_Resolve_Concrete_Type() 
        {
            var container = new Container();

            container.For<ILogger>().Use<SqlServerLogger>();
            container.For<IRepository<Car>>().Use<SqlRepository<Car>>();
            container.For(typeof(IRepository<>)).Use(typeof(SqlRepository<>));

            var service = container.Resolve<OrderingServic>();

            Assert.IsNotNull(service);
        }
    }
}
