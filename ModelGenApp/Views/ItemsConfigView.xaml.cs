namespace ModelGenApp.Views;
/// <summary>
/// Interaction logic for ItemsConfigView.xaml
/// </summary>
public partial class ItemsConfigView : UserControl
{
  public ItemsConfigView()
  {
    InitializeComponent();
  }

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs args)
  {
    var viewModel = DataContext as ModelConfigViewModel;
    if (viewModel != null)
      viewModel.AutoGeneratingColumn(sender, args);
  }
}
