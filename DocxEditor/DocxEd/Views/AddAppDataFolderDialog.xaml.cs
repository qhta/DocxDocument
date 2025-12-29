namespace DocxEd.Views;
/// <summary>
/// Interaction logic for AddAppDataFolderDialog.xaml
/// </summary>
public partial class AddAppDataFolderDialog : Window
{
  public AddAppDataFolderDialog()
  {
    InitializeComponent();
  }

  private void OkButton_Click(object sender, RoutedEventArgs e)
  {
    DialogResult = true;
    Close();
  }

  private void CancelButton_Click(object sender, RoutedEventArgs e)
  {
    DialogResult = false;
    Close();
  }
}
