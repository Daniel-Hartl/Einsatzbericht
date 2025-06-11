namespace EinsatzberichtKonfigurator.Views.Report;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Model;

internal partial class TeamViewModel : ObservableObject
{
    [ObservableProperty]
    private MissionReport report;
}