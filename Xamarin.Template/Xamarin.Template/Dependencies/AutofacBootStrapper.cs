using Autofac;
using Bootstrapping.Modules;
using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bootstrapping
{
    public abstract class AutofacBootStrapper
    {
        private Dictionary<Type, Type> _mappedTypes;

        /// <summary>
        /// Gets a dictionary of platform specific dependencies
        /// </summary>
        /// <param name="mappedTypes">Dictionary of platform specific dependencies</param>
        public void Run(Dictionary<Type, Type> mappedTypes)
        {
            _mappedTypes = mappedTypes;

            ContainerBuilder builder = new ContainerBuilder();

            ConfigureContainer(builder);

            IContainer container = builder.Build();

            IViewFactory viewFactory = container.Resolve<IViewFactory>();

            RegisterViews(viewFactory);

            ConfigureApplication(container);
        }

        protected virtual void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule<AutofacModule>();

            if (_mappedTypes != null && _mappedTypes.Any())
            {
                builder.RegisterModule(new Modules.MappedTypeModule(_mappedTypes));
            }
        }

        protected abstract void RegisterViews(IViewFactory viewFactory);

        protected abstract void ConfigureApplication(IContainer container);
    }
}
