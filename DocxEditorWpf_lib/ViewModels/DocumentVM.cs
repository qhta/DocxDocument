namespace DocxEditor;


/// <summary>
/// ViewModel for Component.Wordprocessing.Document.
/// </summary>
public class DocumentVM : ViewModel<DocumentModel.Wordprocessing.Document>
{
  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="document"></param>
  public DocumentVM(DocumentModel.Wordprocessing.Document document) : base(document)
  {
    document.PropertyChanged += Document_PropertyChanged;
  }

  /// <summary>
  /// Notifies the view that the caption has changed when the IsModified property of the document changes,
  /// allowing the UI to update accordingly (args.g., adding an asterisk to indicate unsaved changes).
  /// </summary>
  /// <param name="sender">The source of the event.</param>
  /// <param name="args">The arguments of the event.</param>
  private void Document_PropertyChanged(object? sender, PropertyChangedEventArgs args)
  {
    if (args.PropertyName == nameof(Document.IsModified))
    {
      NotifyPropertyChanged(nameof(Caption));
    }
  }

  /// <summary>
  /// Model of the document represented by this view model.
  /// </summary>
  public DocumentModel.Wordprocessing.Document Document => Model;

  /// <summary>
  /// Caption for the document, which is typically displayed in the title bar of the application.
  /// </summary>
  public string Caption => (Document?.CoreProperties?.Title ?? Document?.Filename ?? "Untitled")
                           + (Document?.IsModified == true ? " *" : "");

  /// <summary>
  /// Collection of document properties as view models.
  /// </summary>
  public PropertiesVM DocumentProperties
  {
    get
    {
      if (_documentPropertiesVM == null)
      {
        _documentPropertiesVM = new PropertiesVM(this);
      }
      return _documentPropertiesVM;
    }
  }
  private PropertiesVM? _documentPropertiesVM;

  /// <summary>
  /// Components of the document that are exposed as view models for binding in the UI.
  /// </summary>
  public object[] Components =>
    [
      Document.CoreProperties,
      Document.ContentProperties
    ];

  /// <summary>
  /// Component selected in the UI, which can be used to display and edit its properties in a property grid or similar control.
  /// </summary>
  public object? SelectedComponent
  {
    get => _selectedComponent ?? Document.ContentProperties;
    set
    {
      if (value != _selectedComponent)
      {
        _selectedComponent = value;
        NotifyPropertyChanged(nameof(SelectedComponent));
        NotifyPropertyChanged(nameof(SelectedComponentProperties));
      }
    }
  }
  private object? _selectedComponent;


  /// <summary>
  /// Component selected in the UI, which can be used to display and edit its properties in a property grid or similar control.
  /// </summary>
  public PropertiesVM? SelectedComponentProperties =>
    _selectedComponent != null ? new PropertiesVM(_selectedComponent) : null;


  /// <summary>
  /// Custom editors for known property types.
  /// </summary>
  public CustomEditorCollection CustomEditors => _customEditors;

  private static readonly CustomEditorCollection _customEditors = new CustomEditorCollection
  {
    new CustomEditor { PropertyType = typeof(int), EditorType = typeof(IntegerBaseTypeEditor), HasPropertyType = true },
    new CustomEditor { PropertyType = typeof(int?), EditorType = typeof(IntegerBaseTypeEditor), HasPropertyType = true },
    new CustomEditor { PropertyType = typeof(HexBinary), EditorType = typeof(HexBinaryBaseTypeEditor), HasPropertyType = true },

  };

}