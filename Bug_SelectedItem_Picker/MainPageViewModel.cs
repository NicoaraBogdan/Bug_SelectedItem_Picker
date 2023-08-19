using CommunityToolkit.Mvvm.ComponentModel;

namespace Bug_SelectedItem_Picker;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    private int selectedItemFailed = 1;

    [ObservableProperty]
    private int selectedItemSuccess = 1;

    public List<int> ItemsSource { get => new List<int> { 1, 2, 3, 4 }; }

    public MainPageViewModel()
    {
        
    }
}
