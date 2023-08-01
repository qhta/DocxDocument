namespace ModelGenApp.Views;
/// <summary>
/// Interaction logic for NamespacesConfigView.xaml
/// </summary>
public partial class NamespacesConfigView : UserControl
{
  public NamespacesConfigView()
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
