namespace ModelGenApp.Views;
/// <summary>
/// Interaction logic for TypeInfoView.xaml
/// </summary>
public partial class TypeInfoView : UserControl
{
  public TypeInfoView()
  {
    InitializeComponent();
  }

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
  {
    Qhta.WPF.DataGridUtils.AutoGenerating.UseDataGridColumnAttribute(sender, e);
  }
}
