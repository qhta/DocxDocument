namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of borders for the edges of the current table cell, using the eight border types defined by its child elements.
/// </summary>
public partial class TableCellBorders
{
  
  /// <summary>
  ///   Table Cell Top Border.
  /// </summary>
  public DMW.TopBorder? TopBorder { get; set; }
  
  
  /// <summary>
  ///   Table Cell Left Border.
  /// </summary>
  public DMW.LeftBorder? LeftBorder { get; set; }
  
  
  /// <summary>
  ///   StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public DMW.StartBorder? StartBorder { get; set; }
  
  
  /// <summary>
  ///   Table Cell Bottom Border.
  /// </summary>
  public DMW.BottomBorder? BottomBorder { get; set; }
  
  
  /// <summary>
  ///   Table Cell Right Border.
  /// </summary>
  public DMW.RightBorder? RightBorder { get; set; }
  
  
  /// <summary>
  ///   EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public DMW.EndBorder? EndBorder { get; set; }
  
  
  /// <summary>
  ///   Table Cell Inside Horizontal Edges Border.
  /// </summary>
  public DMW.InsideHorizontalBorder? InsideHorizontalBorder { get; set; }
  
  
  /// <summary>
  ///   Table Cell Inside Vertical Edges Border.
  /// </summary>
  public DMW.InsideVerticalBorder? InsideVerticalBorder { get; set; }
  
  
  /// <summary>
  ///   Table Cell Top Left to Bottom Right Diagonal Border.
  /// </summary>
  public DMW.TopLeftToBottomRightCellBorder? TopLeftToBottomRightCellBorder { get; set; }
  
  
  /// <summary>
  ///   Table Cell Top Right to Bottom Left Diagonal Border.
  /// </summary>
  public DMW.TopRightToBottomLeftCellBorder? TopRightToBottomLeftCellBorder { get; set; }
  
}
