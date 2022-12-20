namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Root Element.
/// </summary>
public partial interface GlossaryDocument
{
  /// <summary>
  /// Document Background.
  /// </summary>
  public DocumentModel.Wordprocessing.DocumentBackground? DocumentBackground { get; set; }
  
  /// <summary>
  /// List of Glossary Document Entries.
  /// </summary>
  public DocumentModel.Wordprocessing.DocParts? DocParts { get; set; }
  
  /// <summary>
  /// Gets the GlossaryDocumentPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.GlossaryDocumentPart? GlossaryDocumentPart { get; set; }
  
}
