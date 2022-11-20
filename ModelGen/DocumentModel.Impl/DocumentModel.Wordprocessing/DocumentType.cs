namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Classification.
/// </summary>
public class DocumentType: IDocumentType
{
  /// <summary>
  /// Document Classification Value
  /// </summary>
  public DocumentTypeValues? Val
  {
    get;
    set;
  }
  
}
