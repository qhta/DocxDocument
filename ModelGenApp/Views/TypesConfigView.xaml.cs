namespace ModelGenApp.Views;

public partial class TypesConfigView : UserControl
{
  public TypesConfigView()
  {
    InitializeComponent();
    dataGridColumnCreator = new DataGridColumnCreator(MainDataGrid, typeof(TypeConfigListViewModel), typeof(TypeConfigViewModel))
    { IsFilterButtonVisible = true };
  }

  private DataGridColumnCreator dataGridColumnCreator = null!;

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
  {
    dataGridColumnCreator.GenerateColumn(sender, e);
  }
}
