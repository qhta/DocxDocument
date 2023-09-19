namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PageBorders Class.
/// </summary>
public partial class PageBorders
{
  
  /// <summary>
  ///   Z-Ordering of Page Border
  /// </summary>
  [SchemaAttr("w:zOrder")]
  public DocumentModel.Wordprocessing.PageBorderZOrderValues? ZOrder { get; set; }
  
  
  /// <summary>
  ///   Pages to Display Page Borders
  /// </summary>
  [SchemaAttr("w:display")]
  public DocumentModel.Wordprocessing.PageBorderDisplayValues? Display { get; set; }
  
  
  /// <summary>
  ///   Page Border Positioning
  /// </summary>
  [SchemaAttr("w:offsetFrom")]
  public DocumentModel.Wordprocessing.PageBorderOffsetValues? OffsetFrom { get; set; }
  
  
  /// <summary>
  ///   Top Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? TopBorder { get; set; }
  
  
  /// <summary>
  ///   Left Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? LeftBorder { get; set; }
  
  
  /// <summary>
  ///   Bottom Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? BottomBorder { get; set; }
  
  
  /// <summary>
  ///   Right Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? RightBorder { get; set; }
  
}
