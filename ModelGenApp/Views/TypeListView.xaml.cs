using System.Windows.Controls;
using System.Windows.Data;

namespace ModelGenApp.Views;
/// <summary>
/// Interaction logic for TypeListView.xaml
/// </summary>
public partial class TypeListView : UserControl
{
  public TypeListView()
  {
    InitializeComponent();
  }

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
  {
    Qhta.WPF.DataGridUtils.AutoGenerating.CreateCollectionCountColumn(sender, e, "CollectionCountColumnTemplate" );
    if (!e.Cancel)
    {
      Qhta.WPF.DataGridUtils.AutoGenerating.UseDataGridColumnAttribute(sender, e);
    }
  }
}
