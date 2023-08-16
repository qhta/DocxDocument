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

  private DataGridColumnCreator dataGridColumnCreator = null!;

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
  {
    if (dataGridColumnCreator == null)
    {
      if (DataContext is ClassListViewModel)
        dataGridColumnCreator = new DataGridColumnCreator(MainDataGrid, 
          typeof(ClassListViewModel), typeof(ClassInfoViewModel));
      else
      if (DataContext is EnumTypeListViewModel)
        dataGridColumnCreator = new DataGridColumnCreator(MainDataGrid,
          typeof(EnumTypeListViewModel), typeof(EnumTypeInfoViewModel));
      else
        dataGridColumnCreator = new DataGridColumnCreator(MainDataGrid, 
          typeof(TypeListViewModel), typeof(TypeInfoViewModel));
    }
    dataGridColumnCreator.GenerateColumn(sender, e);
  }
}
