namespace EinsatzberichtKonfigurator.Views.Report;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EinsatzberichtKonfigurator.Classes;
using Model;
using Model.enums;
using Model.MasterData;
using System.Collections.ObjectModel;
using System.Windows;

internal partial class TeamViewModel : ObservableObject
{
    [ObservableProperty]
    private MissionReport report;

    [ObservableProperty]
    private FirefighterProvider firefighterProvider = new FirefighterProvider();

    [ObservableProperty]
    private ObservableCollection<Person> filteredPersons;

    [ObservableProperty]
    private string newFirefighterInput;

    [RelayCommand]
    private void RemoveFirefighter(Firefighter firefighter)
    {
        if (MessageBox.Show($"{firefighter.Name} wirklich entfernen?", string.Empty, MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            this.report.Team.Remove(firefighter);
    }

    [RelayCommand]
    private void SetHlf(Firefighter firefighter) => firefighter.Vehicle = Vehicle.HLF;
    [RelayCommand]
    private void SetMtw(Firefighter firefighter) => firefighter.Vehicle = Vehicle.MTW;
    [RelayCommand]
    private void SetPrivate(Firefighter firefighter) => firefighter.Vehicle = Vehicle.privVehicle;
}