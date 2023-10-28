namespace ModelGenApp.Views;
/// <summary>
/// Interaction logic for ProcessOptionsView.xaml
/// </summary>
public partial class ProcessOptionsView : UserControl
{
  public ProcessOptionsView()
  {
    InitializeComponent();
  }

  private void Button_CanExecute(object sender, CanExecuteRoutedEventArgs args)
  {
    var button = (Button)sender;
    args.CanExecute = button.Command.CanExecute(null);
  }

  private void ShowTypeSelectionBox_Click(object sender, RoutedEventArgs e)
  {
    TypeSelectionBox.Visibility = System.Windows.Visibility.Visible;
    TypeSelectionBox.IsDropDownOpen = true;
  }

  private void TypeSelectionBox_DropDownClosed(object sender, EventArgs e)
  {
    TypeSelectionBox.Visibility = System.Windows.Visibility.Collapsed;
  }
}
