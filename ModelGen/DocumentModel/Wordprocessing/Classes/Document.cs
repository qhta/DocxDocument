namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the contents of a main document part in a WordprocessingML document.
/// </summary>
public partial class Document
{
  
  /// <summary>
  ///   conformance
  /// </summary>
  public DocumentConformance? Conformance { get; set; }
  
  
  /// <summary>
  ///   Document Background.
  /// </summary>
  public DocumentBackground? DocumentBackground { get; set; }
  
  
  /// <summary>
  ///   Body.
  /// </summary>
  public Body? Body { get; set; }
  
}
