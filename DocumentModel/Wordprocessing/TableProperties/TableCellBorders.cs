namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TableCellBorders Class.
/// </summary>
public class TableCellBorders: ModelElement
{
  /// <summary>
  ///   Table Cell Top Border.
  /// </summary>
  public Border? TopBorder { get; set; }

  /// <summary>
  ///   Table Cell Left Border.
  /// </summary>
  public Border? LeftBorder { get; set; }

  /// <summary>
  ///   StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public Border? StartBorder { get; set; }

  /// <summary>
  ///   Table Cell Bottom Border.
  /// </summary>
  public Border? BottomBorder { get; set; }

  /// <summary>
  ///   Table Cell Right Border.
  /// </summary>
  public Border? RightBorder { get; set; }

  /// <summary>
  ///   EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public Border? EndBorder { get; set; }

  /// <summary>
  ///   Table Cell Inside Horizontal Edges Border.
  /// </summary>
  public Border? InsideHorizontalBorder { get; set; }

  /// <summary>
  ///   Table Cell Inside Vertical Edges Border.
  /// </summary>
  public Border? InsideVerticalBorder { get; set; }

  /// <summary>
  ///   Table Cell Top Left to Bottom Right Diagonal Border.
  /// </summary>
  public Border? TopLeftToBottomRightCellBorder { get; set; }

  /// <summary>
  ///   Table Cell Top Right to Bottom Left Diagonal Border.
  /// </summary>
  public Border? TopRightToBottomLeftCellBorder { get; set; }
}