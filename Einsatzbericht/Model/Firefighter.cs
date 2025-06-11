namespace Model;

using CommunityToolkit.Mvvm.ComponentModel;
using Model.enums;

public partial class Firefighter: ObservableObject
{
    [ObservableProperty]
    private string chipId;

    [ObservableProperty]
    private string name;

    [ObservableProperty]    
    private Vehicle vehicle;

    [ObservableProperty]
    private string? paNr;

    [ObservableProperty]
    private TimeSpan? paTime;

    [ObservableProperty]
    private string comment;
}
