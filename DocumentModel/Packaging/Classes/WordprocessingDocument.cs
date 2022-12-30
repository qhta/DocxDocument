namespace DocumentModel.Packaging;

/// <summary>
/// Defines WordprocessingDocument - an OpenXmlPackage represents a Word document.
/// </summary>
public partial class WordprocessingDocument
{
  /// <summary>
  /// Gets the type of the WordprocessingDocument.
  /// </summary>
  public DocumentModel.WordprocessingDocumentType? DocumentType { get; set; }
  
}
