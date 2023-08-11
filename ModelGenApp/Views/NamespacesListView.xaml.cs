namespace ModelGenApp.Views;

public partial class NamespacesListView : UserControl
{
  public NamespacesListView()
  {
    InitializeComponent();
  }

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
  {
    AutoGenerating.UseDataGridColumnAttribute(sender, e);
  }
}
