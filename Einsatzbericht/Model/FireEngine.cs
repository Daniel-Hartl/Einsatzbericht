namespace Model;

using CommunityToolkit.Mvvm.ComponentModel;

public partial class FireEngine: ObservableObject
{
    [ObservableProperty]
    private bool isUsed = true;

    [ObservableProperty]
    private string radioName;

    [ObservableProperty]
    private DateTime departureGH = DateTime.Now;

    [ObservableProperty]
    private DateTime arrivalEST = DateTime.Now;

    [ObservableProperty]
    private DateTime departureEST;

    [ObservableProperty]
    private DateTime arrivalGH;

    [ObservableProperty]
    private int distance;

    [ObservableProperty]
    private string machinist;

    [ObservableProperty]
    private string leader;
}
