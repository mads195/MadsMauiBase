using CommunityToolkit.Maui.Core;
using MadsMauiBase.ViewModels.StarterKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MadsMauiBase.ViewModels.Examples
{
    public class FormViewModel : MvvmBase
    {
        /**
         * Properties
         */
        public ICommand ShowPopupCommand { get; set; }
        private readonly IPopupService oPopupServiceZ;
        /**
         * Constructor
         */
        public FormViewModel(IPopupService oPopupServiceZ)
        {
            this.oPopupServiceZ = oPopupServiceZ;
            /**
             * Actions
             */
            ShowPopupCommand = new Command(async x => await ShowPopup(x));
        }
        /// <summary>
        /// Run on view appearing
        /// </summary>
        /// <returns></returns>
        public async Task Appearing()
        {

        }
        /// <summary>
        /// Show the popup
        /// </summary>
        /// <param name="oContextZ"></param>
        /// <returns></returns>
        private async Task ShowPopup(object oContextZ)
        {
            await this.oPopupServiceZ.ShowPopupAsync<MadsPopupViewModel>(onPresenting: viewModel => viewModel.VTitle = "Mads195 Popup");
        }
    }
}
