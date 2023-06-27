using System.Windows.Controls;

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
}
