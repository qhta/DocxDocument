namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the contents of a main document part in a WordprocessingML document.
/// </summary>
public partial class Document
{
  
  /// <summary>
  ///   conformance
  /// </summary>
  public DocumentModel.Wordprocessing.DocumentConformance? Conformance { get; set; }
  
  
  /// <summary>
  ///   Document Background.
  /// </summary>
  public DocumentModel.Wordprocessing.DocumentBackground? DocumentBackground { get; set; }
  
  
  /// <summary>
  ///   Body.
  /// </summary>
  public DocumentModel.Wordprocessing.Body? Body { get; set; }
  
}
