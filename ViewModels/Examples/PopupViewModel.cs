using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mads195.MadsMauiLib.ViewModels.Controls;

namespace MadsMauiBase.ViewModels.Examples
{
    public partial class PopupViewModel : ObservableObject
    {
        private readonly IPopupService oGenericPopupServiceZ;
        [ObservableProperty]
        string clickOnScreenTitleResult = "";
        [ObservableProperty]
        int clickOnScreenTitleCount = 0;

        public PopupViewModel(IPopupService oGenericPopupServiceZ)
        {
            this.oGenericPopupServiceZ = oGenericPopupServiceZ;
        }

        /// <summary>
        /// Run on view appearing
        /// </summary>
        /// <returns></returns>
        public async Task Appearing()
        {

        }
        [RelayCommand]
        internal async Task OnShowPopup()
        {
            //FlexiDialogViewModel oFlexiDialogVmZ = null;
            var oValueZ = await this.oGenericPopupServiceZ.ShowPopupAsync<Mads195.MadsMauiLib.ViewModels.Controls.FlexiDialogViewModel>(onPresenting: viewModel =>
            {
                viewModel.DialogType = Mads195.MadsMauiLib.ViewModels.Controls.FlexiDialogType.IndeterminateTransfer;
                viewModel.Title = "Hello World";
                viewModel.Message = "Loading oddities...";
                viewModel.Keyboard = Keyboard.Default;
                viewModel.ButtonSubmitText = "OK";
                viewModel.ButtonCancelText = "Cancel";

                viewModel.UpdateMessage(2000, "Discombobulating strangulations...");

                viewModel.UpdateMessage(2000, "This is a story about a little kitten and her journey around the world.");
                
                MainThread.InvokeOnMainThreadAsync(async () =>
                {
                    await MyTestMethod(viewModel);
                });
            });


            if (oValueZ is FlexiDialogResponse oFlexiDialogResponseZ &&
                oFlexiDialogResponseZ.ButtonClicked == FlexiDialogButton.Submit)
            {
                string input = oFlexiDialogResponseZ.Value?.Trim();
            }
        }

        public async Task MyTestMethod(FlexiDialogViewModel viewModel)
        {
            viewModel.UpdateMessage(2000, "This is my updated message");
            // Do something here
        }

        [RelayCommand]
        internal async Task OnClickEndImage()
        {
            clickOnScreenTitleCount++;
            ClickOnScreenTitleResult = $"Clicked the image {ClickOnScreenTitleCount} times.";
        }
    }
}
