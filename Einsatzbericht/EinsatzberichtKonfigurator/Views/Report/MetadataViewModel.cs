namespace EinsatzberichtKonfigurator.Views.Report;

using CommunityToolkit.Mvvm.ComponentModel;
using Model;

internal partial class MetadataViewModel: ObservableObject
{
    [ObservableProperty]
    private MissionReport report;
}
