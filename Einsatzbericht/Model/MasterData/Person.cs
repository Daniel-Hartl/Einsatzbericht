namespace Model.MasterData;

using CommunityToolkit.Mvvm.ComponentModel;

public partial class Person: ObservableObject
{
    [ObservableProperty]
    private string chipId;

    [ObservableProperty]
    private string name;
}
