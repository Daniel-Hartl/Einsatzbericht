namespace Model;

using CommunityToolkit.Mvvm.ComponentModel;

public partial class Address: ObservableObject
{
    [ObservableProperty]
    private string street;

    [ObservableProperty]
    private string houseNumber;

    [ObservableProperty]
    private string postalCode;

    [ObservableProperty]
    private string city;
}
