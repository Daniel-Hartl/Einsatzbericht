namespace EinsatzberichtKonfigurator;

using EinsatzberichtKonfigurator.Classes;
using System.IO;
using System.Text.Json;
using System.Windows;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    internal static Config Config { get; private set; }

    public App()
    {
        string content = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Konfiguration.json"));
        Config = JsonSerializer.Deserialize<Config>(content);
        if (Config is null)
            Environment.FailFast("Keine Konfigurationsdatei gefunden!");

        this.InitializeComponent();
    }
}

