namespace EinsatzberichtKonfigurator.Views.Report;

using Model;
using System.Windows.Controls;

/// <summary>
/// Interaction logic for MissionRessources.xaml
/// </summary>
public partial class MissionRessources : UserControl
{
    public MissionRessources(MissionReport missionReport)
    {
        InitializeComponent();
        this.vm.Report = missionReport;
    }
}
