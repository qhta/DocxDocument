using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media.Animation;

using DocumentFormat.OpenXml.Wordprocessing;

using DocxEditor.ViewModels;
using DocxEditor.Views;

using Qhta.MVVM;
using Syncfusion.Windows.Tools.Controls;

namespace DocxEditor;


/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
  public MainWindow()
  {
    InitializeComponent();
  }

  private void FileOpen_Executed(object sender, ExecutedRoutedEventArgs e)
  {
    var dialog = new Microsoft.Win32.OpenFileDialog();
    dialog.InitialDirectory = @"d:\OneDrive\VS\Projects\DocxDocument\DocxDocument.Test\Samples";
      //Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    //dialog.FileName = "Document"; // Default file name
    dialog.DefaultExt = ".docx"; // Default file extension
    dialog.Filter = "Word documents (.docx)|*.docx"; // Filter files by extension

    bool? result = dialog.ShowDialog();
    if (result == true)
    {
      string filename = dialog.FileName;
      var document = new DocumentModel.Wordprocessing.Document();
      document.Open(filename);
      var documentVM = new DocumentVM(document);
      var documentView = new DocumentView();
      documentView.DataContext = documentVM;
      AddFloatingView(documentView, "Document", documentVM.Caption);
    }
  }

  private void ViewModel_ActiveViewChanged(object sender, DependencyPropertyChangedEventArgs e)
  {
    ActiveView = (e.NewValue as DockItem)?.Content as System.Windows.Controls.Control;
  }

  ///// <summary>
  ///// Gets the commander responsible for managing operations within the system.
  ///// </summary>
  //public _Commander Commander { get; }

  /// <summary>
  /// Add a view to the docking manager.
  /// </summary>
  /// <param name="view"></param>
  /// <param name="windowName"></param>
  /// <param name="header"></param>
  public void AddFloatingView(System.Windows.Controls.Control view, string windowName, string? header)
  {
    if (DataContext is MDIViewModel viewModel)
    {
      if (windowName.Contains('#'))
      {
        var nameCount = viewModel.DockCollections.Count(dockItem => dockItem.Name.StartsWith(windowName)) + 1;
        windowName = windowName.Replace("#", nameCount.ToString()).Replace(" ", "_");
      }

      //var dockItem = new DockItem
      //{
      //  Name = windowName,
      //  Header = header,
      //  State = DockState.Float,
      //  CanFloatMaximize = true,
      //  Content = view,
      //};


      DocumentContainer.Items.Add(view);
      DocumentContainer.SetHeader(view, header);

      //// Get top-left of dockingManager in screen pixels
      Point screenTopLeftPx = DocumentContainer.PointToScreen(new Point(0, 0));

      // Convert to device-independent units (DIPs) if DPI scaling is not 100%
      var source = PresentationSource.FromVisual(DocumentContainer);
      if (source?.CompositionTarget is not null)
      {
        // TransformFromDevice converts physical pixels -> DIPs
        var toDip = source.CompositionTarget.TransformFromDevice;
        screenTopLeftPx = toDip.Transform(screenTopLeftPx);
      }
      var n = DocumentContainer.Items.Count;
      // Relative cascade offset in DIPs
      double offset = 20 * n;

      // Desired size
      double desiredWidth = 1000;
      double desiredHeight = 800;

      var newBounds = new Rect(offset, offset, desiredWidth, desiredHeight);

      //// Final rect in screen coordinates (DIPs)
      //dockItem.FloatingWindowRect = new Rect(
      //  screenTopLeftPx.X + offset,
      //  screenTopLeftPx.Y + offset,
      //  width,
      //  height);


      DocumentContainer.SetMDIBounds(view, newBounds);
      DocumentContainer.ActiveDocument = view;
    }
  }

  /// <summary>
  /// Gets or sets the currently active view in the MainWindow.
  /// </summary>
  public System.Windows.Controls.Control? ActiveView { get; set; }


  private void DockingManager_OnActiveWindowChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
  {
    var activeWindow = e.NewValue;
    ActiveView = (activeWindow as ContentControl)?.Content as System.Windows.Controls.Control;
    //Commander.FileSaveCommand.NotifyCanExecuteChanged();
    //Commander.ViewCopyCommand.NotifyCanExecuteChanged();

  }
}