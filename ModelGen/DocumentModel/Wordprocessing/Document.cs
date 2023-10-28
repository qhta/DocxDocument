namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the contents of a main document part in a WordprocessingML document.
/// </summary>
public partial class Document
{
  
  /// <summary>
  ///   Document Background.
  /// </summary>
  public DMW.DocumentBackground? DocumentBackground { get; set; }
  
  
  /// <summary>
  ///   Body.
  /// </summary>
  public DMW.Body? Body { get; set; }
  
}
