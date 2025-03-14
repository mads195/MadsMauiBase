using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MadsMauiBase.ViewModels.StarterKit
{
    public partial class MadsPopupViewModel : ObservableObject
    {
        /**
         * Properties
         */
        [ObservableProperty]
        string vTitle = "";
        [ObservableProperty]
        string vMessage = "";
        [ObservableProperty]
        string vName = "";

        readonly IPopupService oPopupServiceZ;

        /**
         * Constructor
         */
        public MadsPopupViewModel(IPopupService oPopupServiceZ)
        {
            this.oPopupServiceZ = oPopupServiceZ;
        }
        /**
         * Commands
         * You may be asking why these work! RelayCommand is a class from the CommunityToolkit.Maui package 
         * and generates a corresponding ICommand property in the background. The method OnCancel created a 
         * command called CancelCommand and likewise for SaveCommand.
         */
        [RelayCommand(CanExecute = nameof(CanCancel))]
        void OnCancel()
        {
            oPopupServiceZ.ClosePopup();
        }
        [RelayCommand(CanExecute = nameof(CanSave))]
        void OnSave()
        {
            oPopupServiceZ.ClosePopup(VName);
        }
        /**
         * Dynamic Properties
         */
        bool CanSave() => string.IsNullOrWhiteSpace(VName) is false;
        bool CanCancel() => true;
        public bool bHasTitle => !string.IsNullOrEmpty(VTitle);
        public bool bHasMessage => !string.IsNullOrEmpty(VMessage);
        /**
         * Event Handlers
         */
        partial void OnVTitleChanged(string value) => OnPropertyChanged(nameof(bHasTitle));
        partial void OnVMessageChanged(string value) => OnPropertyChanged(nameof(bHasMessage));
        
    }
}
