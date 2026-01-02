namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TableCellBorders Class.
/// </summary>
public class TableCellBorders: ModelElement
{
  /// <summary>
  ///   Table Cell Top Border.
  /// </summary>
  public IBorder? TopBorder { get; set; }
  /// <summary>
  ///   Table Cell Left Border.
  /// </summary>
  public IBorder? LeftBorder { get; set; }
  /// <summary>
  ///   StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public IBorder? StartBorder { get; set; }
  /// <summary>
  ///   Table Cell Bottom Border.
  /// </summary>
  public IBorder? BottomBorder { get; set; }
  /// <summary>
  ///   Table Cell Right Border.
  /// </summary>
  public IBorder? RightBorder { get; set; }
  /// <summary>
  ///   EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public IBorder? EndBorder { get; set; }
  /// <summary>
  ///   Table Cell Inside Horizontal Edges Border.
  /// </summary>
  public IBorder? InsideHorizontalBorder { get; set; }
  /// <summary>
  ///   Table Cell Inside Vertical Edges Border.
  /// </summary>
  public IBorder? InsideVerticalBorder { get; set; }
  /// <summary>
  ///   Table Cell Top Left to Bottom Right Diagonal Border.
  /// </summary>
  public IBorder? TopLeftToBottomRightCellBorder { get; set; }
  /// <summary>
  ///   Table Cell Top Right to Bottom Left Diagonal Border.
  /// </summary>
  public IBorder? TopRightToBottomLeftCellBorder { get; set; }
}