using System;
using System.Linq;
using System.Reflection;

namespace SiliconPanda.Shared.Core.Tests.Convention
{
    public abstract class ConventionBase
    {
        protected Type[] GetPublicClassesFromApplicationAssembly(Predicate<Type> where)
        {
            return Assembly.Load(AssemblyName).GetExportedTypes()
                .Where(t => t.IsClass)
                .Where(t => t.IsAbstract == false)
                .Where(where.Invoke)
                .OrderBy(t => t.Name)
                .ToArray();
        }
        protected Type[] GetPublicInterfacesFromApplicationAssembly(Predicate<Type> where)
        {
            return Assembly.Load(AssemblyName).GetExportedTypes()
                .Where(t => t.IsInterface)
                .Where(where.Invoke)
                .OrderBy(t => t.Name)
                .ToArray();
        }

        private const string AssemblyName = "SiliconPanda.Shared.Core";
    }
}
