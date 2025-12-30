using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Qhta.MVVM;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;

namespace DocxEditor;

/// <summary>
/// ViewModel for Multi Document Interface
/// </summary>
public class MDIViewModel: ViewModel
{
  private SwitchMode switchMode= SwitchMode.Immediate;

  /// <summary>
  /// This property enables you to control how tabs behave, with different SwitchMode values like Immediate, List, None, Quick Tabs, VS2005, and VistaFlip to provide different switching experiences. 
  /// </summary>
  public SwitchMode SwitchMode
  {
    get => switchMode;
    set
    {
      switchMode = value;
      NotifyPropertyChanged(nameof(this.SwitchMode));
    }
  }

  /// <summary>
  /// Command to change MDI layout (Cascade, Horizontal, Vertical)
  /// </summary>
  public ICommand MDILayoutChangedCommand { get; set; }

  /// <summary>
  /// Initializing constructor,
  /// </summary>
  public MDIViewModel()
  {
    MDILayoutChangedCommand = new DelegateCommand<object>(MDILayoutChanged);
  }


  private void MDILayoutChanged(object obj)
  {
    if (obj is object?[] parameters && parameters[0] is not null && parameters[1] is DockingManager dockingManager)
    {
      if (dockingManager.DocContainer is DocumentContainer documentContainer)
      {
        switch (parameters[0]!.ToString())
        {
          case "Cascade":
            documentContainer.SetLayout(MDILayout.Cascade);
            documentContainer.ActiveDocumentChanged += DocumentContainer_ActiveDocumentChanged;
            break;
          case "Horizontal":
            documentContainer.SetLayout(MDILayout.Horizontal);
            documentContainer.ActiveDocumentChanged += DocumentContainer_ActiveDocumentChanged;
            break;
          case "Vertical":
            documentContainer.SetLayout(MDILayout.Vertical);
            documentContainer.ActiveDocumentChanged += DocumentContainer_ActiveDocumentChanged;
            break;
        }
      }
    }
  }

  /// <summary>
  /// Observe active view changes on the docking manager.
  /// </summary>
  /// <param name="dockingManager"></param>
  public void ActiveViewChangedOn(DockingManager dockingManager)
  {
    if (dockingManager.DocContainer is DocumentContainer documentContainer)
    {
      documentContainer.ActiveDocumentChanged += DocumentContainer_ActiveDocumentChanged;
    }
  }

  private void DocumentContainer_ActiveDocumentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
  {
    ActiveViewChanged?.Invoke(d, e);
  }

  /// <summary>
  /// Bridge event to notify when the active view has changed in the docking manager.
  /// </summary>
  public event DependencyPropertyChangedEventHandler? ActiveViewChanged;

  /// <summary>
  /// Collection of DockItems for managing dockable panels in the UI.
  /// </summary>
  public ObservableCollection<DockItem> DockCollections { get; } = new ObservableCollection<DockItem>();

}