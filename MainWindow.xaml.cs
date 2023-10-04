using Microsoft.UI.Xaml;

namespace xBindUserControlDataContextRepro;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        root.Loaded += (s, e) => test.DataContext = new TestViewModel();
    }
}
