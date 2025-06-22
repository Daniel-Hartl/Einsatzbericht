namespace EinsatzberichtKonfigurator.Views.Report;

using Model;
using Model.MasterData;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

/// <summary>
/// Interaction logic for Team.xaml
/// </summary>
public partial class Team : UserControl
{
    public Team(MissionReport missionReport)
    {
        InitializeComponent();
        this.vm.Report = missionReport;
    }

    private void SearchBoxChanged(object sender, TextChangedEventArgs e)
    {
        if (sender is TextBox textBox)
        {
            this.vm.FilteredPersons = [.. this.vm.FirefighterProvider.Firefighters.Where(x => x.ChipId.Contains(textBox.Text, StringComparison.OrdinalIgnoreCase)
            || x.Name.Contains(textBox.Text, StringComparison.OrdinalIgnoreCase))];
        }
    }

    private void OnKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter && this.vm.FilteredPersons.Count == 1)
        {
            Person pers = this.vm.FilteredPersons[0];

            if (this.vm.Report.Team.Any(x => x.Name.Contains(pers.Name) || x.ChipId.Contains(pers.ChipId)))
                MessageBox.Show($"{pers.Name} wurde bereits hinzugefügt.");

            else
                this.vm.Report.Team.Add(new()
                {
                    ChipId = pers.ChipId,
                    Name = pers.Name,
                });



            this.searchTb.Text = string.Empty;
            e.Handled = true;
        }
    }

    private void NameClicked(object sender, MouseButtonEventArgs e)
    {
        if (sender is DockPanel dp && dp.DataContext is Person pers)
        {
            this.vm.Report.Team.Add(new()
            {
                ChipId = pers.ChipId,
                Name = pers.Name,
            });

            this.searchTb.Text = string.Empty;
        }
    }
}
