// Alisson Assis
using AcademiaTioAlisson.Presentation.AppMaui.Views;

namespace AcademiaTioAlisson.Presentation.AppMaui;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute("logradouro", typeof(LogradouroPage));
    }
}