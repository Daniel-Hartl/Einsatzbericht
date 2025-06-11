namespace Model;

using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Specialized;
using System.ComponentModel;

public partial class MissionReportChangeTracker : ObservableObject, IDisposable
{
    [ObservableProperty]
    private bool hasChanges;

    private readonly List<ObservableObject> trackedEntities = [];

    public MissionReportChangeTracker(MissionReport report)
    {
        if (report is null)
            return;

        this.Report = report;
        this.Report.PropertyChanged += this.OnReportChanged;
        this.Report.Vehicles.CollectionChanged += this.OnReportCollectionChanged;
        this.Report.Team.CollectionChanged += this.OnReportCollectionChanged;
        this.Report.MissionRessources.CollectionChanged += this.OnReportCollectionChanged;

        this.trackedEntities.AddRange(this.Report.Vehicles);
        this.trackedEntities.AddRange(this.Report.Team);
        this.trackedEntities.AddRange(this.Report.MissionRessources);

        this.trackedEntities.ForEach(obj => obj.PropertyChanged += this.OnReportChanged);

    }

    private void OnReportCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        this.HasChanges = true;
        if (e.Action == NotifyCollectionChangedAction.Add)
        {
            foreach (ObservableObject obj in e.NewItems)
            {
                obj.PropertyChanged += this.OnReportChanged;
                this.trackedEntities.Add(obj);
            }
        }
        else if (e.Action == NotifyCollectionChangedAction.Remove)
        {
            foreach (ObservableObject obj in e.OldItems)
            {
                obj.PropertyChanged -= this.OnReportChanged;
                this.trackedEntities.Remove(obj);
            }
        }
    }

    public MissionReport Report { get; init; }

    public void Dispose()
    {
        this.Report.PropertyChanged -= this.OnReportChanged;
        this.Report.Vehicles.CollectionChanged -= this.OnReportCollectionChanged;
        this.Report.Team.CollectionChanged -= this.OnReportCollectionChanged;
        this.Report.MissionRessources.CollectionChanged -= this.OnReportCollectionChanged;

        this.trackedEntities.ForEach(obj => obj.PropertyChanged -= this.OnReportChanged);
        this.trackedEntities.Clear();
    }

    private void OnReportChanged(object sender, PropertyChangedEventArgs args) => this.HasChanges = true;
}
