using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;
using Xamarin.Forms;

namespace Factory
{
    public class ViewFactory : IViewFactory
    {
        private readonly IDictionary<Type, Type> _map = new Dictionary<Type, Type>();
        private readonly IComponentContext _componentContext;

        public ViewFactory(IComponentContext componentContext)
        {
            _componentContext = componentContext;
        }


        public void Register<TViewModel, TView>()
            where TViewModel : class, IViewModel
            where TView : Page
        {
            _map[(typeof(TViewModel))] = typeof(TView);
        }

        public Page Resolve<TViewModel>()
            where TViewModel : class, IViewModel
        {
            TViewModel viewModel = _componentContext.Resolve<TViewModel>();
            Type viewType = _map[(typeof(TViewModel))];

            Page view = _componentContext.Resolve(viewType) as Page;

            view.BindingContext = viewModel;
            return view;
        }
    }
}
