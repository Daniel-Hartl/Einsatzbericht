namespace EinsatzberichtKonfigurator.Views.Report;

using Model;
using System.Windows.Controls;
using System.Windows.Input;

/// <summary>
/// Interaction logic for Metadata.xaml
/// </summary>
public partial class Metadata : UserControl
{
    public Metadata(MissionReport missionReport)
    {
        InitializeComponent();
        this.vm.Report = missionReport;
    }

    private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
    {
        if (sender is TextBox textBox && e.Key is Key.Enter)
        {
            int caretIndex = textBox.CaretIndex;
            textBox.Text = textBox.Text.Insert(caretIndex, "\n");
            textBox.CaretIndex = ++caretIndex;
            e.Handled = true;
        }
    }
}
