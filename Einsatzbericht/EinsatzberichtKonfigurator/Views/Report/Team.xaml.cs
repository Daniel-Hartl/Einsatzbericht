namespace EinsatzberichtKonfigurator.Views.Report;

using Model;
using System.Windows.Controls;

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
}
