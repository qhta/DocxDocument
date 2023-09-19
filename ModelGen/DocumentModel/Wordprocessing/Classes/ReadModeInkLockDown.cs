namespace DocumentModel.Wordprocessing;


/// <summary>
///   Freeze Document Layout.
/// </summary>
public partial class ReadModeInkLockDown
{
  
  /// <summary>
  ///   Use Actual Pages, Not Virtual Pages
  /// </summary>
  [SchemaAttr("w:actualPg")]
  public Boolean? UseActualPages { get; set; }
  
  
  /// <summary>
  ///   Virtual Page Width
  /// </summary>
  [SchemaAttr("w:w")]
  public UInt32? Width { get; set; }
  
  
  /// <summary>
  ///   Virtual Page Height
  /// </summary>
  [SchemaAttr("w:h")]
  public UInt32? Height { get; set; }
  
  
  /// <summary>
  ///   Font Size Scaling
  /// </summary>
  [SchemaAttr("w:fontSz")]
  public String? FontSize { get; set; }
  
}
