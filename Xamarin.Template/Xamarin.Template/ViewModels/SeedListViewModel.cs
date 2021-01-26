using Business.Models;
using Business.Services;
using FatHead.Converters;
using Messages;
using Navigation;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ViewModels
{
    public class SeedListViewModel : BaseViewModel
    {
        private ISeedService _seedService;

        /// <summary>
        /// SeedTypeViewModel constructor
        /// </summary>
        /// <param name="navigator">INavigator view model navigation</param>
        /// <param name="toastMessage">IToastMessage platform specific ToastMessage</param>
        /// <param name="seedService">ISeedService Test, Api, and Database</param>
        public SeedListViewModel(INavigator navigator, IToastMessage toastMessage, ISeedService seedService)
            : base(navigator, toastMessage)
        {
            _seedService = seedService;
            OCSeedList = new ObservableCollection<Seed>();
        }

        public ObservableCollection<Seed> OCSeedList { get; set; }

        /// <summary>
        /// Uses the SeedService to load the seeds for a specific seed type.
        /// For testing purposes the SeedTestService is used with preloaded seeds.
        /// The SeedDBService will be used to connect to a local Sqlite Database.
        /// The SeedApiService will be used to connect to an api to pull the seed types.
        /// </summary>
        private async void LoadSeeds()
        {
            IList<Seed> temp = await _seedService.GetList(GetSeedTypeParameter());

            OCSeedList.Clear();

            foreach (Seed s in temp)
            {
                OCSeedList.Add(s);
            }
        }

        private string GetSeedTypeParameter()
        {
            foreach (var p in Parameters)
            {
                if (p.Key == "Type")
                {
                    return p.Value;
                }
            }

            return string.Empty;
        }

        public override void OnAppearing()
        {
            LoadSeeds();
        }
    }
}
