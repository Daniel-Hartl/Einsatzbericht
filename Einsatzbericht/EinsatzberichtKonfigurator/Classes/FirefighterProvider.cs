namespace EinsatzberichtKonfigurator.Classes;

using Model;
using Model.MasterData;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using System.Windows;

internal class FirefighterProvider
{
    private static ObservableCollection<Person> firefighters;

    internal FirefighterProvider()
    {
        if(Firefighters is null)
            Init(App.Config.FireFighterConfigFile);
    }

    public ObservableCollection<Person> Firefighters => firefighters;

    internal static void Init(string containingFile)
    {
        try
        {
            firefighters = JsonSerializer.Deserialize<ObservableCollection<Person>>(File.ReadAllText(containingFile));
        }
        catch (Exception exc)
        {
            MessageBox.Show($"Fehler beim Laden der Mannschaftsstammdaten. Dies kann zu Beeinträchtigungen im Einsatzkräfte-Reiter führen." +
                $" Bitte die Konfiguration prüfen Fehler: {exc}", string.Empty, MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
