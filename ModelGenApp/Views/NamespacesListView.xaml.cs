namespace ModelGenApp.Views;

public partial class NamespacesListView : UserControl
{
  public NamespacesListView()
  {
    InitializeComponent();
  }

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
  {
    Qhta.WPF.DataGridUtils.AutoGenerating.UseDataGridColumnAttribute(sender, e);
  }
}
