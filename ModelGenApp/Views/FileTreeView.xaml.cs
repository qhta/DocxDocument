namespace ModelGenApp.Views;
/// <summary>
/// Interaction logic for FileTreeView.xaml
/// </summary>
public partial class FileTreeView : UserControl
{
  public FileTreeView()
  {
    InitializeComponent();
    myClickWaitTimer = 
          new DispatcherTimer(
          new TimeSpan(0, 0, 0, 0, 200),
          DispatcherPriority.Background,
          mouseWaitTimer_Tick,
          Dispatcher.CurrentDispatcher);
  }

  private DispatcherTimer myClickWaitTimer;


  private void FileItem_MouseLeftButtonDown(object sender, MouseButtonEventArgs args)
  {
    if (sender is FrameworkElement control && control.DataContext is FileViewModel fileViewModel)
      if (args.ClickCount == 2)
      {
        myClickWaitTimer.Start();
        _fileViewModel = fileViewModel;
        args.Handled = true;
      }
  }

  private FileViewModel? _fileViewModel = null!;

  private void mouseWaitTimer_Tick(object? sender, EventArgs e)
  {
    myClickWaitTimer.Stop();
    if (_fileViewModel != null)
      _fileViewModel.ShowDetailsCommand.Execute(_fileViewModel);
  }
}
