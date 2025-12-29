using DocxEd.ViewModels;

namespace DocxEd.Views;

public partial class ModelConfigWindow : Window
{
  public ModelConfigWindow()
  {
    InitializeComponent();
  }

  private void CancelButton_Click(object sender, RoutedEventArgs e)
  {
    (DataContext as ConfigListViewModel)?.RestoreDataCommand.Execute(null);
    Close();
  }
}
