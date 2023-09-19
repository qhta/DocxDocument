namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of borders for the edges of the current table cell, using the eight border types defined by its child elements.
/// </summary>
public partial class TableCellBorders
{
  
  /// <summary>
  ///   Table Cell Top Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? TopBorder { get; set; }
  
  
  /// <summary>
  ///   Table Cell Left Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? LeftBorder { get; set; }
  
  
  /// <summary>
  ///   StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? StartBorder { get; set; }
  
  
  /// <summary>
  ///   Table Cell Bottom Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? BottomBorder { get; set; }
  
  
  /// <summary>
  ///   Table Cell Right Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? RightBorder { get; set; }
  
  
  /// <summary>
  ///   EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? EndBorder { get; set; }
  
  
  /// <summary>
  ///   Table Cell Inside Horizontal Edges Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? InsideHorizontalBorder { get; set; }
  
  
  /// <summary>
  ///   Table Cell Inside Vertical Edges Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? InsideVerticalBorder { get; set; }
  
  
  /// <summary>
  ///   Table Cell Top Left to Bottom Right Diagonal Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? TopLeftToBottomRightCellBorder { get; set; }
  
  
  /// <summary>
  ///   Table Cell Top Right to Bottom Left Diagonal Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? TopRightToBottomLeftCellBorder { get; set; }
  
}
