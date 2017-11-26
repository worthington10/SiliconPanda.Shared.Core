﻿using System.Linq;
using NUnit.Framework;
using SiliconPanda.Shared.Core.Convention;

namespace SiliconPanda.Shared.Core.Tests.Convention
{
    [TestFixture]
    public class ConfigurationTests : ConventionBase
    {
        [Test]
        public void AllManagers_ShouldHaveTheIManagerInterface()
        {
            var allManagers = GetPublicClassesFromApplicationAssembly(c => c.Name.EndsWith("Configuration"));
            var allInterfaces = GetPublicClassesFromApplicationAssembly(c => c.GetInterfaces().Contains(typeof(IConfiguration)));

            Assert.AreEqual(allManagers.Length, allInterfaces.Length);
            Assert.AreEqual(allManagers.Select(x => x.FullName), allInterfaces.Select(x => x.FullName));
        }
    }
}
