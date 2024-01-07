namespace ModelGenApp.Views
{
  /// <summary>
  /// Interaction logic for PropertiesConfigView.xaml
  /// </summary>
  public partial class PropertiesConfigView : UserControl
  {
    public PropertiesConfigView()
    {
      InitializeComponent();
      dataGridColumnCreator = new DataGridColumnCreator(MainDataGrid, typeof(PropertiesConfigListViewModel), typeof(PropertyConfigViewModel))
      { IsFilterButtonVisible = true };
    }

    private DataGridColumnCreator dataGridColumnCreator = null!;

    private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
    {
      dataGridColumnCreator.GenerateColumn(sender, e);
    }
  }
}
