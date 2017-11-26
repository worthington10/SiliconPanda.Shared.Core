using System.Linq;
using NUnit.Framework;
using SiliconPanda.Shared.Core.Convention;

namespace SiliconPanda.Shared.Core.Tests.Convention
{
    [TestFixture]
    public class FactoryTests : ConventionBase
    {
        [Test]
        public void AllFactories_ShouldHaveTheIManagerInterface()
        {
            var allManagers = GetPublicClassesFromApplicationAssembly(c => c.Name.EndsWith("Factory"));
            var allInterfaces = GetPublicClassesFromApplicationAssembly(c => c.GetInterfaces().Contains(typeof(IFactory)));

            Assert.AreEqual(allManagers.Length, allInterfaces.Length);
            Assert.AreEqual(allManagers.Select(x => x.FullName), allInterfaces.Select(x => x.FullName));
        }
    }
}
