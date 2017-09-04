using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zib3l
{
    public class Zib3lContainer
    {
        readonly Dictionary<Type, Type> _registrations = new Dictionary<Type, Type>();

        public void Register<Tregistration, TImplementation>()
        {
            _registrations.Add(typeof(Tregistration), typeof(TImplementation));
        }

        public object Resolve<T>()
        {
            var request_type = typeof(T);
            Type actual_type = _registrations[request_type];
            var instance = Activator.CreateInstance(actual_type);
            return (T) instance;
        }
    }
}
