using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadsMauiBase.ViewModels.Examples
{
    public partial class HomeViewModel : MvvmBase
    {
        /**
         * Properties
         */

        /**
         * Constructor
         */
        public HomeViewModel()
        {
            //
        }
        /// <summary>
        /// Run on view appearing
        /// </summary>
        /// <returns></returns>
        public async Task Appearing()
        {

        }
        [RelayCommand]
        internal async Task OnOpenPopup()
        {
            await Shell.Current.GoToAsync("popupviewmodel");
        }
    }
}
