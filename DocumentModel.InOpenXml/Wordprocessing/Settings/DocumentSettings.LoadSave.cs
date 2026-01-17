namespace DocumentModel.Wordprocessing;

public partial class DocumentSettings
{

  /// <summary>
  /// Gets the underlying WordprocessingDocument instance associated with this object.
  /// </summary>
  internal DXPP.WordprocessingDocument? WordprocessingDocument { get; private set; }

  /// <summary>
  /// Default constructor.
  /// </summary>
  public DocumentSettings()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="document">Wordprocessing document model</param>
  public DocumentSettings(Wordprocessing.Document document)
  {
    AttachAndLoad(document);
  }

  /// <summary>
  /// Attach this instance to the specified document. Data is loaded from the document's PackageProperties.
  /// </summary>
  /// <param name="document">Document to attach to.</param>
  public void AttachAndLoad(Wordprocessing.Document document)
  {
    WordprocessingDocument = document.WordprocessingDocument;
    var documentSettings = document.WordprocessingDocument?.GetDocumentSettings();
    if (documentSettings != null)
    {
      SetOpenXmlElement(documentSettings);
      LoadData(documentSettings);
    }
  }

  /// <summary>
  /// Attach this instance to the specified document. Data is stored to the document's PackageProperties.
  /// </summary>
  /// <param name="document">Document to attach to.</param>
  public void AttachAndUpdate(Wordprocessing.Document document)
  {
    WordprocessingDocument = document.WordprocessingDocument;
    var documentSettings = document.WordprocessingDocument?.GetDocumentSettings();
    if (documentSettings != null)
    {
      SetOpenXmlElement(documentSettings);
      UpdateData(documentSettings);
    }
  }

  /// <summary>
  /// Detach this instance from the specified document.
  /// Underlying Open XML element is set to null, so further access to its properties will not work until re-attached.
  /// </summary>
  /// <param name="document">Document to detach from. Must be the same as the one attached.</param>
  public void Detach(Wordprocessing.Document document)
  {
    if (WordprocessingDocument != document.WordprocessingDocument)
      return;
    WordprocessingDocument = null;
    SetOpenXmlElement(null);
  }

}

