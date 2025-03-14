using CommunityToolkit.Maui.Views;
using MadsMauiBase.ViewModels.StarterKit;

namespace MadsMauiBase.Controls.StarterKit;

public partial class MadsPopup : Popup
{
    public MadsPopup(MadsPopupViewModel oVmZ)
    {
        InitializeComponent();
        BindingContext = oVmZ;

        
        MadsPopupWindow.WidthRequest = DeviceDisplay.Current.MainDisplayInfo.Width / DeviceDisplay.Current.MainDisplayInfo.Density;
        //MadsPopupWindow.Margin = 20;
        Console.WriteLine($"Width: {DeviceDisplay.Current.MainDisplayInfo.Width}");
        Console.WriteLine($"Width: {DeviceDisplay.Current.MainDisplayInfo.Height}");
    }
}
