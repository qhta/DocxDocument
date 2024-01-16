namespace ModelGenApp.Views;

public partial class LibrariesConfigView : UserControl
{
  public LibrariesConfigView()
  {
    InitializeComponent();
  }

  private DataGridColumnCreator? dataGridColumnCreator = null;

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs args)
  {
    if (dataGridColumnCreator == null && sender is DataGrid dataGrid)
    {
      var dataContextViewModelType = dataGrid.DataContext?.GetType();
      if (dataContextViewModelType != null && dataContextViewModelType.IsEnumerable(out var itemType))
      {
        dataGridColumnCreator = new DataGridColumnCreator(dataGrid, dataContextViewModelType, itemType);
      }
    }
    if (dataGridColumnCreator != null)
    {
      dataGridColumnCreator.GenerateColumn(sender, args);
    }
  }

  private void DataGrid_InitializingNewItem(object sender, InitializingNewItemEventArgs  args)
  {
  }

}
