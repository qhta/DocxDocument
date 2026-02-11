namespace DocxEditor.ViewModels;


/// <summary>
/// ViewModel for DocumentModel.Wordprocessing.Document.
/// </summary>
public class DocumentVM: ViewModel<DocumentModel.Wordprocessing.Document>
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
    if (args.PropertyName==nameof(Document.IsModified))
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
  public DocumentPropertiesVM DocumentProperties
  {
    get
    {
      if (_documentPropertiesVM == null)
      {
        _documentPropertiesVM = new DocumentPropertiesVM(this);
      }
      return _documentPropertiesVM;
    }
  }
  private DocumentPropertiesVM? _documentPropertiesVM;

  //public RelayCommand ResetCommand => new RelayCommand(Reset);

  //private void Reset()
  //{
  //  Debug.WriteLine("Reset");
  //}

}