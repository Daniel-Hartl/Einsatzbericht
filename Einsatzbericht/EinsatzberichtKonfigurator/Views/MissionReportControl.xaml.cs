namespace EinsatzberichtKonfigurator.Views;

using EinsatzberichtKonfigurator.Views.Report;
using Model;
using System.Windows;
using System.Windows.Controls;

/// <summary>
/// Interaction logic for MissionReport.xaml
/// </summary>
public partial class MissionReportControl : UserControl
{
    public static readonly DependencyProperty ReportProperty =
        DependencyProperty.Register(
            nameof(MissionReport),
            typeof(MissionReport),
            typeof(MissionReportControl),
            new PropertyMetadata(null)
        );

    public MissionReportControl()
    {
        Report = new();
        InitializeComponent();
        this.vm.Report = this.Report;
        metadata.Content = new Metadata(Report);
        team.Content = new Team(Report);
        ressources.Content = new MissionRessources(Report);
    }

    public MissionReport Report
    {
        get => (MissionReport)GetValue(ReportProperty);
        set
        {
            SetValue(ReportProperty, value);
            if (this.vm is not null)
                this.vm.Report = value;
        }
    }
}
