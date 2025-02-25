using CommunityToolkit.Maui.Alerts;
using MadsMauiBase.Services.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MadsMauiBase.ViewModels
{
    public class MvvmBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /**
         * Clipboard
         */
        protected readonly IClipboardService _clipboardService;
        public Command<string> ClipboardCommand { get; }

        /**
         * Methods
         */
        public MvvmBase(IClipboardService? clipboardService = null)
        {
            if (clipboardService != null)
            {
                _clipboardService = clipboardService;
                ClipboardCommand = new Command<string>(async (text) => await CopyToClipboardAsync(text));
            }
        }
        /// <summary>
        /// Copy text to the clipboard
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private async Task CopyToClipboardAsync(string text)
        {
            try
            {
                await _clipboardService.CopyToClipboardAsync(text);
            }
            catch (Exception ex)
            {
                var oToastZ = Toast.Make("Error copying to the keyboard");
                CancellationToken oCancellationTokenZ = new CancellationToken();
                await oToastZ.Show(oCancellationTokenZ);
            }
        }
    }
}
