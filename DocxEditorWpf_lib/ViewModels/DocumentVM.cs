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
  }

  public DocumentModel.Wordprocessing.Document Document => Model;

  public string Caption => Document?.CoreProperties?.Title ?? "Untitled";

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
}