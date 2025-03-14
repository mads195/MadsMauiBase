using MadsMauiBase.ViewModels.Examples;

namespace MadsMauiBase.Views.Examples;

public partial class FormView : ContentPage
{
	public FormView(FormViewModel oVmZ)
	{
		InitializeComponent();
        BindingContext = oVmZ;

        Appearing += Page_Appearing;
    }

    private async void Page_Appearing(object? sender, EventArgs e)
    {
        await ((FormViewModel)BindingContext).Appearing();
    }
}