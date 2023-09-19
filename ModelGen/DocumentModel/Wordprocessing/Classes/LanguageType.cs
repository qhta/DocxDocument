namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the LanguageType Class.
/// </summary>
public partial class LanguageType
{
  
  /// <summary>
  ///   Latin Language
  /// </summary>
  [SchemaAttr("w:val")]
  public String? Val { get; set; }
  
  
  /// <summary>
  ///   East Asian Language
  /// </summary>
  [SchemaAttr("w:eastAsia")]
  public String? EastAsia { get; set; }
  
  
  /// <summary>
  ///   Complex Script Language
  /// </summary>
  [SchemaAttr("w:bidi")]
  public String? Bidi { get; set; }
  
}
