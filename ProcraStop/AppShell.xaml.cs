using ProcraStop.Pages.MenuPages;
using ProcraStop.Pages.StartPages;
namespace ProcraStop;
public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(VistaPrueba), typeof(VistaPrueba));

    }
}
