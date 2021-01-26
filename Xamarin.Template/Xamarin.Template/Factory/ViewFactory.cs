using Autofac;
using System;
using System.Collections.Generic;
using ViewModels;
using Xamarin.Forms;

namespace Factory
{
    public class ViewFactory : IViewFactory
    {
        private readonly IDictionary<Type, Type> _map = new Dictionary<Type, Type>();
        private readonly IComponentContext _componentContext;

        /// <summary>
        /// View Factory Constructor
        /// </summary>
        /// <param name="componentContext">IComponentContext</param>
        public ViewFactory(IComponentContext componentContext)
        {
            _componentContext = componentContext;
        }

        /// <summary>
        /// Maps the views to the view models
        /// </summary>
        /// <typeparam name="TViewModel">IViewModel</typeparam>
        /// <typeparam name="TView">Page</typeparam>
        public void Register<TViewModel, TView>()
            where TViewModel : class, IViewModel
            where TView : Page
        {
            _map[(typeof(TViewModel))] = typeof(TView);
        }

        /// <summary>
        /// Resolves the Page from the view model
        /// </summary>
        /// <typeparam name="TViewModel">IViewModel</typeparam>
        /// <returns>Page</returns>
        public Page Resolve<TViewModel>()
            where TViewModel : class, IViewModel
        {
            TViewModel viewModel = _componentContext.Resolve<TViewModel>();
            Type viewType = _map[(typeof(TViewModel))];

            Page view = _componentContext.Resolve(viewType) as Page;

            view.BindingContext = viewModel;
            return view;
        }

        /// <summary>
        /// Resolves the Page from the view model.  Allows for view models to pass parameters to other view models.
        /// </summary>
        /// <typeparam name="TViewModel">IViewModel</typeparam>
        /// <param name="parameters">Dictionary of parameters</param>
        /// <returns>Page</returns>
        public Page Resolve<TViewModel>(Dictionary<string, string> parameters)
            where TViewModel : class, IViewModel
        {
            TViewModel viewModel = _componentContext.Resolve<TViewModel>();
            Type viewType = _map[(typeof(TViewModel))];

            Page view = _componentContext.Resolve(viewType) as Page;

            view.BindingContext = viewModel;

            viewModel.Parameters = parameters;

            return view;
        }
    }
}
