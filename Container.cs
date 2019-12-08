using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDI
{
    public enum Lifetime
    {
        Singleton,
        Transient
    }

    public static class Container
    {
        private static readonly Dictionary<Type, Type> _registeredTransientServices = new Dictionary<Type, Type>();
        private static readonly Dictionary<Type, object> _registeredSingletonServices = new Dictionary<Type, object>();

        public static void Register<TInterface, TClass>(Lifetime lifetime) where TClass : class
        {
            if(lifetime == Lifetime.Singleton)
                _registeredSingletonServices.Add(typeof(TInterface), Activator.CreateInstance<TClass>());
            else
            {
                _registeredTransientServices.Add(typeof(TInterface), typeof(TClass));
            }
        }

        public static TInterface Resolve<TInterface>()
        {
            if (_registeredSingletonServices.ContainsKey(typeof(TInterface)))
                return (TInterface) _registeredSingletonServices[typeof(TInterface)];

            var typeToCreate = _registeredTransientServices[typeof(TInterface)];
            return (TInterface) Activator.CreateInstance(typeToCreate);
        }
    }
}
