namespace EinsatzberichtKonfigurator.Classes;

using CommunityToolkit.Mvvm.ComponentModel;

internal partial class Config: ObservableObject
{
    [ObservableProperty]
    private string fireFighterConfigFile;

    [ObservableProperty]
    private string itemsConfig;

    [ObservableProperty]
    private string standardSaveDirectory;
}
