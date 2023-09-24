namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of borders for the edges of the current table, using the six border types defined by its child elements.
/// </summary>
public partial class TableBorders
{
  
  /// <summary>
  ///   Table Top Border.
  /// </summary>
  public BorderType? TopBorder { get; set; }
  
  
  /// <summary>
  ///   Table Left Border.
  /// </summary>
  public BorderType? LeftBorder { get; set; }
  
  
  /// <summary>
  ///   StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public BorderType? StartBorder { get; set; }
  
  
  /// <summary>
  ///   Table Bottom Border.
  /// </summary>
  public BorderType? BottomBorder { get; set; }
  
  
  /// <summary>
  ///   Table Right Border.
  /// </summary>
  public BorderType? RightBorder { get; set; }
  
  
  /// <summary>
  ///   EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public BorderType? EndBorder { get; set; }
  
  
  /// <summary>
  ///   Table Inside Horizontal Edges Border.
  /// </summary>
  public BorderType? InsideHorizontalBorder { get; set; }
  
  
  /// <summary>
  ///   Table Inside Vertical Edges Border.
  /// </summary>
  public BorderType? InsideVerticalBorder { get; set; }
  
}
