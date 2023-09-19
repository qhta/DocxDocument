namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PageSize Class.
/// </summary>
public partial class PageSize
{
  
  /// <summary>
  ///   Page Width
  /// </summary>
  [SchemaAttr("w:w")]
  public UInt32? Width { get; set; }
  
  
  /// <summary>
  ///   Page Height
  /// </summary>
  [SchemaAttr("w:h")]
  public UInt32? Height { get; set; }
  
  
  /// <summary>
  ///   Page Orientation
  /// </summary>
  [SchemaAttr("w:orient")]
  public DocumentModel.Wordprocessing.PageOrientationValues? Orient { get; set; }
  
  
  /// <summary>
  ///   Printer Paper Code
  /// </summary>
  [SchemaAttr("w:code")]
  public UInt16? Code { get; set; }
  
}
