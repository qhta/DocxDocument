namespace ModelGenApp.Views;

public partial class ModelConfigWindow : Window
{
  public ModelConfigWindow()
  {
    InitializeComponent();
  }

  private void CancelButton_Click(object sender, RoutedEventArgs e)
  {
    (DataContext as ModelConfigViewModel)?.RestoreDataCommand.Execute(null);
    Close();
  }
}
