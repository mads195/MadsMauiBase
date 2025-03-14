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
        /**
         * Properties
         */

        /**
         * Constructor
         */
        public ClipboardViewModel(IClipboardService clipboardService) : base(clipboardService)
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
    }
}
