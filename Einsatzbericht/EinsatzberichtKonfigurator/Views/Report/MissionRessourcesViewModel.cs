namespace EinsatzberichtKonfigurator.Views.Report;

using CommunityToolkit.Mvvm.ComponentModel;
using Model;

internal partial class MissionRessourcesViewModel : ObservableObject
{
    [ObservableProperty]
    private MissionReport report;
}