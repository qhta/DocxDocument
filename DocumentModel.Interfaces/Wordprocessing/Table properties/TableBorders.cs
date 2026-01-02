namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TableBorders Class.
/// </summary>
public class TableBorders: ModelElement
{
  /// <summary>
  ///   Table Top Border.
  /// </summary>
  public IBorder? TopBorder { get; set; }
  /// <summary>
  ///   Table Left Border.
  /// </summary>
  public IBorder? LeftBorder { get; set; }
  /// <summary>
  ///   StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public IBorder? StartBorder { get; set; }
  /// <summary>
  ///   Table Bottom Border.
  /// </summary>
  public IBorder? BottomBorder { get; set; }
  /// <summary>
  ///   Table Right Border.
  /// </summary>
  public IBorder? RightBorder { get; set; }
  /// <summary>
  ///   EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public IBorder? EndBorder { get; set; }
  /// <summary>
  ///   Table Inside Horizontal Edges Border.
  /// </summary>
  public IBorder? InsideHorizontalBorder { get; set; }
  /// <summary>
  ///   Table Inside Vertical Edges Border.
  /// </summary>
  public IBorder? InsideVerticalBorder { get; set; }
}