namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FontCharSet Class.
/// </summary>
public partial class FontCharSet
{
  
  /// <summary>
  ///   val
  /// </summary>
  [SchemaAttr("w:val")]
  public String? Val { get; set; }
  
  
  /// <summary>
  ///   characterSet
  /// </summary>
  [SchemaAttr("w:characterSet")]
  public DocumentModel.Wordprocessing.StrictCharacterSet? StrictCharacterSet { get; set; }
  
}
