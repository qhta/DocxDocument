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
    AutoGenerating.UseDataGridColumnAttribute(sender, e);
  }
}
