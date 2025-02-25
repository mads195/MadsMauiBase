using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadsMauiBase.Services.Utilities
{
    public interface IClipboardService
    {
        Task CopyToClipboardAsync(string value);
    }
    public class ClipboardService : IClipboardService
    {
        public async Task CopyToClipboardAsync(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return;
            }

            await Clipboard.SetTextAsync(value);
        }
    }
}
