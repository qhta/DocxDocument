namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Classification.
/// </summary>
public interface IDocumentType // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Document Classification Value
  /// </summary>
  public DocumentType? Val { get ; set; }
  
}
