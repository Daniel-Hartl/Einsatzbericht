namespace Model;

using CommunityToolkit.Mvvm.ComponentModel;

public partial class MissionResource : ObservableObject
{
    [ObservableProperty]
    private string fireManagerId;

    [ObservableProperty]
    private string name;

    [ObservableProperty]
    private string? damages;

    public bool IsDamaged => !string.IsNullOrEmpty(damages);
}
