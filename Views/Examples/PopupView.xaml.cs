using MadsMauiBase.ViewModels.Examples;

namespace MadsMauiBase.Views.Examples;

public partial class PopupView : ContentPage
{
	public PopupView(PopupViewModel oVmZ)
	{
		InitializeComponent();
        BindingContext = oVmZ;
        Appearing += Page_Appearing;
    }
    private async void Page_Appearing(object? sender, EventArgs e)
    {
        await ((PopupViewModel)BindingContext).Appearing();
    }
}