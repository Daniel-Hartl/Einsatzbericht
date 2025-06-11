namespace EinsatzberichtKonfigurator.Views;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using Model;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Windows;

internal partial class MissionReportViewModel : ObservableRecipient
{
    private MissionReport report;

    [ObservableProperty]
    private MissionReportChangeTracker changeTracker;

    public MissionReport Report
    {
        get => this.report;
        set
        {
            if (this.ChangeTracker is not null)
                this.ChangeTracker.Dispose();
            this.report = value;
            this.ChangeTracker = new(this.report);
            this.OnPropertyChanged();
        }
    }

    [RelayCommand]
    private void Save()
    {
        SaveFileDialog fd = new();
        fd.Filter = "Einsatzbericht (*.bericht)|*.bericht";
        fd.Title = "Bericht speichern";
        if (fd.ShowDialog() ?? false)
        {
            try
            {
                string report = JsonSerializer.Serialize(this.report);
                using FileStream fs = new(fd.FileName, FileMode.Create);
                using StreamWriter sw = new(fs, Encoding.UTF8);
                sw.Write(report);
                sw.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Speichern des Berichts. Fehlerdetails: {ex}");
            }
        }
    }

    [RelayCommand]
    private void Close()
    {

    }
}
