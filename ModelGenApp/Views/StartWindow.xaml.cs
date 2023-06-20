namespace ModelGenApp.Views;

/// <summary>
/// Interaction logic for StartWindow.xaml
/// </summary>
public partial class StartWindow : Window
{
  public StartWindow()
  {
    InitializeComponent();
  }

  private void CloseCommand_Executed(object sender, ExecutedRoutedEventArgs e)
  {
    this.Close();
  }
}
