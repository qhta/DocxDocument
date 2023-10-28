namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of borders for the edges of the current table, using the six border types defined by its child elements.
/// </summary>
public partial class TableBorders
{
  
  /// <summary>
  ///   Table Top Border.
  /// </summary>
  public DMW.TopBorder? TopBorder { get; set; }
  
  
  /// <summary>
  ///   Table Left Border.
  /// </summary>
  public DMW.LeftBorder? LeftBorder { get; set; }
  
  
  /// <summary>
  ///   StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public DMW.StartBorder? StartBorder { get; set; }
  
  
  /// <summary>
  ///   Table Bottom Border.
  /// </summary>
  public DMW.BottomBorder? BottomBorder { get; set; }
  
  
  /// <summary>
  ///   Table Right Border.
  /// </summary>
  public DMW.RightBorder? RightBorder { get; set; }
  
  
  /// <summary>
  ///   EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public DMW.EndBorder? EndBorder { get; set; }
  
  
  /// <summary>
  ///   Table Inside Horizontal Edges Border.
  /// </summary>
  public DMW.InsideHorizontalBorder? InsideHorizontalBorder { get; set; }
  
  
  /// <summary>
  ///   Table Inside Vertical Edges Border.
  /// </summary>
  public DMW.InsideVerticalBorder? InsideVerticalBorder { get; set; }
  
}
