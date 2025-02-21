using MadsMauiBase.ViewModels.Examples;

namespace MadsMauiBase.Views.Examples;

public partial class ClipboardView : ContentPage
{
    public ClipboardView(ClipboardViewModel oVmZ)
    {
        BindingContext = oVmZ;
        InitializeComponent();

        Appearing += Page_Appearing;
    }

    private async void Page_Appearing(object? sender, EventArgs e)
    {
        await ((ClipboardViewModel)BindingContext).InitializeModel();
    }
}
