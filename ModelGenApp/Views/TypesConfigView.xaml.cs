namespace ModelGenApp.Views;

public partial class TypesConfigView : UserControl
{
  public TypesConfigView()
  {
    InitializeComponent();
  }

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
  {
    DataGridColumnCreator.GenerateColumn(sender, e);
  }
}
