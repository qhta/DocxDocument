namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document.
/// </summary>
public interface Document
{
  /// <summary>
  /// conformance
  /// </summary>
  public DocumentModel.Wordprocessing.DocumentConformance? Conformance { get ; set; }
  
  /// <summary>
  /// Document Background.
  /// </summary>
  public DocumentModel.Wordprocessing.DocumentBackground? DocumentBackground { get ; set; }
  
  /// <summary>
  /// Body.
  /// </summary>
  public DocumentModel.Wordprocessing.Body? Body { get ; set; }
  
}
