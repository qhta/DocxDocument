namespace ModelGenApp.Views;

public partial class NamespacesListView : UserControl
{
  public NamespacesListView()
  {
    InitializeComponent();
    dataGridColumnCreator =  new DataGridColumnCreator(MainDataGrid, typeof(NamespacesViewModel), typeof(NamespaceViewModel)) { IsFilterButtonVisible = true };
  }

  private DataGridColumnCreator dataGridColumnCreator = null!;

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
  {
    dataGridColumnCreator.GenerateColumn(sender, e);
  }
}
