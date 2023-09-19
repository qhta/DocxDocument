namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PageMargin Class.
/// </summary>
public partial class PageMargin
{
  
  /// <summary>
  ///   Top Margin Spacing
  /// </summary>
  [SchemaAttr("w:top")]
  public Int32? Top { get; set; }
  
  
  /// <summary>
  ///   Right Margin Spacing
  /// </summary>
  [SchemaAttr("w:right")]
  public UInt32? Right { get; set; }
  
  
  /// <summary>
  ///   Page Bottom Spacing
  /// </summary>
  [SchemaAttr("w:bottom")]
  public Int32? Bottom { get; set; }
  
  
  /// <summary>
  ///   Left Margin Spacing
  /// </summary>
  [SchemaAttr("w:left")]
  public UInt32? Left { get; set; }
  
  
  /// <summary>
  ///   Spacing to Top of Header
  /// </summary>
  [SchemaAttr("w:header")]
  public UInt32? Header { get; set; }
  
  
  /// <summary>
  ///   Spacing to Bottom of Footer
  /// </summary>
  [SchemaAttr("w:footer")]
  public UInt32? Footer { get; set; }
  
  
  /// <summary>
  ///   Page Gutter Spacing
  /// </summary>
  [SchemaAttr("w:gutter")]
  public UInt32? Gutter { get; set; }
  
}
