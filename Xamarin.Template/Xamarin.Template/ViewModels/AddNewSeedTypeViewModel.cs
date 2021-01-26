using Business.Models;
using Business.Services;
using Messages;
using Navigation;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ViewModels
{
    public class AddNewSeedTypeViewModel : BaseViewModel
    {
        private readonly ISeedTypeService _seedTypeService;
        private SeedType _seedType;
        private string _type;

        /// <summary>
        /// MainViewModel Constructor
        /// </summary>
        /// <param name="navigator">INavigator view model navigation</param>
        /// <param name="toastMessage">IToastMessage platform specific ToastMessage</param>
        /// <param name="seedTypeService">ISeedTypeService Test, Api, and Database</param>
        public AddNewSeedTypeViewModel(INavigator navigator, IToastMessage toastMessage, ISeedTypeService seedTypeService)
            : base(navigator, toastMessage)
        {
            _seedTypeService = seedTypeService;
            AddNewSeedTypeCommand = new Command(AddNewSeedType);
            CancelCommand = new Command(Cancel);
        }

        /// <summary>
        /// Command to add the new seed type
        /// </summary>
        public ICommand AddNewSeedTypeCommand { get; set; }

        /// <summary>
        /// Command to cancel the request and navigate back to the SeedTypePage.
        /// </summary>
        public ICommand CancelCommand { get; set; }

        public SeedType SeedType
        {
            get
            {
                return _seedType;
            }
            set
            {
                _seedType = value;
                NotifyPropertyChanged("SeedType");
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
                UpdateModel();
                NotifyPropertyChanged("Type");
            }
        }

        private void UpdateModel()
        {
            this.SeedType = new SeedType() { Type = this.Type };
        }

        private async void AddNewSeedType()
        {
            int result = await _seedTypeService.Post(_seedType);

            if (result == 0)
            {
                GetToastMessage().Show("New seed type not added.");
            }
            else
            {
                GetToastMessage().Show("New seed type added.");
            }

            this.Type = string.Empty;
        }

        private async void Cancel()
        {
            try
            {
                await GetNavigator().PopAsync();
            }
            catch (Exception ex)
            {
                GetToastMessage().Show(ex.Message);
            }
        }
    }
}
