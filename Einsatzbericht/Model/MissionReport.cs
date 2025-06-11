namespace Model;

using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

public partial class MissionReport : ObservableObject
{
    [ObservableProperty]
    private DateTime alarmTime = DateTime.Now;

    [ObservableProperty]
    private string missionDescription;

    [ObservableProperty]
    private string comments;

    [ObservableProperty]
    private Address missionAddress = new();


    [ObservableProperty]
    private string causerName;

    [ObservableProperty]
    private Address causerAddress = new();

    [ObservableProperty]
    private string causerPhoneNumber;

    [ObservableProperty]
    private string additionalCauserInfo;


    [ObservableProperty]
    private string missionLeader;

    [ObservableProperty]
    private ObservableCollection<FireEngine> vehicles
        = [ new (){ RadioName = "42/1" }, new (){ RadioName = "14/1" } ];
 
    [ObservableProperty]
    private string additionalComments;

    [ObservableProperty]
    private ObservableCollection<Firefighter> team = [];

    [ObservableProperty]
    private ObservableCollection<MissionResource> missionRessources = [];
}
