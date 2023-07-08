using System.Windows.Controls;
using System.Windows.Data;

using ModelGenApp.ViewHelpers;
using ModelGenApp.ViewModels;

using Qhta.TypeUtils;

namespace ModelGenApp.Views;
/// <summary>
/// Interaction logic for PhaseResultsView.xaml
/// </summary>
public partial class PhaseResultsView : UserControl
{
  public PhaseResultsView()
  {
    InitializeComponent();
  }

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
  {
    Qhta.WPF.DataGridUtils.AutoGenerating.UseDataGridColumnAttribute(sender, e);
    if (!e.Cancel)
      Qhta.WPF.DataGridUtils.AutoGenerating.CreateCollectionCountColumn(sender, e, "CollectionCountColumnTemplate" );
  }
}
