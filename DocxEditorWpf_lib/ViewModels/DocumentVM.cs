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

  public string Caption => Document?.Properties?.Title ?? "Untitled";

  /// <summary>
  /// Collection of document properties as view models.
  /// </summary>
  public DocumentPropertiesVM DocumentProperties
  {
    get
    {
      if (_documentPropertiesVM == null)
      {
        Document.Properties ??= new DocumentModel.AllDocumentProperties(Document);
        _documentPropertiesVM = new DocumentPropertiesVM(Document.Properties);
      }
      return _documentPropertiesVM;
    }
  }
  private DocumentPropertiesVM? _documentPropertiesVM;
}