using System.Linq;
using NUnit.Framework;

namespace SiliconPanda.Shared.Core.Tests.Convention
{
    [TestFixture]
    public class ManagerTests : ConventionBase
    {
        public void OnlyManagers_ShouldBeInTheManagerNamespace()
        {
            
        }

        public void AllManagers_ShouldHaveTheIManagerInterface()
        {
        //    var allManagers = GetPublicClassesFromApplicationAssembly(c => c.Name.EndsWith("Manager"));
        //    var allManagers = GetPublicClassesFromApplicationAssembly(c => c.Namespace.EndsWith("IManager"));

        //    allManagers.ToList().Should().Equal(registeredManagers, (ac, rc) => ac.Name == rc.Name);
        }
    }
}
