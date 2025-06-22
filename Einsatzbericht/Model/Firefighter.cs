namespace Model;

using CommunityToolkit.Mvvm.ComponentModel;
using Model.enums;
using Model.MasterData;

public partial class Firefighter : Person
{
    [ObservableProperty]
    private Vehicle? vehicle;

    [ObservableProperty]
    private string? paNr;

    [ObservableProperty]
    private int paTime;

    [ObservableProperty]
    private string comment;
}
