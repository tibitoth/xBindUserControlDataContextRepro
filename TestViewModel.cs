using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace xBindUserControlDataContextRepro;

public partial class TestViewModel : ObservableObject
{
    [ObservableProperty]
    private int _value = 0;

    [RelayCommand]
    public void IncrementValue()
    {
        if (Value == 4)
        {
            Value = 0;
        }
        else
        {
            Value++;
        }
    }
}
