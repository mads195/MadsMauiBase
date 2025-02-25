using MadsMauiBase.Services.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadsMauiBase.ViewModels.Examples
{
    public class ClipboardViewModel : MvvmBase
    {
        public ClipboardViewModel(IClipboardService clipboardService) : base(clipboardService)
        {
            //
        }
        public async Task Initialize()
        {

        }
    }
}
