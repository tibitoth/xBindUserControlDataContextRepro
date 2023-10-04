using Microsoft.UI;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;

namespace xBindUserControlDataContextRepro;

public sealed partial class TestUserControl : UserControl
{
    public TestUserControl()
    {
        InitializeComponent();

        DataContextChanged += (s, e) =>
        {
            // uncomment this to fix the issue
            Bindings.Update();
        };
    }

    public TestViewModel ViewModel => (TestViewModel)DataContext;

    private Brush GetBackground(int value)
    {
        return value switch
        {
            0 => new SolidColorBrush(Colors.Red),
            1 => new SolidColorBrush(Colors.Green),
            2 => new SolidColorBrush(Colors.Blue),
            3 => new SolidColorBrush(Colors.Yellow),
            4 => new SolidColorBrush(Colors.Purple),
            _ => new SolidColorBrush(Colors.Black),
        };
    }
}
