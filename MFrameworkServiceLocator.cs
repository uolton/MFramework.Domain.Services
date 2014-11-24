using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MFramework.Infrastructure.ServiceLocator;
using MFramework.Infrastructure.ServiceLocator.WindsorAdapter;

namespace MFramework.Domain.Services
{
    public class MFrameworkServiceLocator : ThreadedServiceLocator
    {
        private static Lazy<MFrameworkServiceLocator> _instance= new Lazy<MFrameworkServiceLocator>(() => new MFrameworkServiceLocator());
        private  MFrameworkServiceLocator() : base(new WindsorAdapter())
        {
        }


        public static MFrameworkServiceLocator Current
        {
            get { return _instance.Value; }

        }
    }
}
