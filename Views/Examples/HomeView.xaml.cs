using MadsMauiBase.ViewModels.Examples;

namespace MadsMauiBase.Views.Examples;

public partial class HomeView : ContentPage
{
	public HomeView(HomeViewModel oVmZ)
	{
        BindingContext = oVmZ;
        InitializeComponent();

        Appearing += Page_Appearing;
    }
    private async void Page_Appearing(object? sender, EventArgs e)
    {
        await ((HomeViewModel)BindingContext).Initialize();
    }
}