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
  public BorderType? TopBorder { get; set; }

  /// <summary>
  ///   Table Cell Left Border.
  /// </summary>
  public BorderType? LeftBorder { get; set; }

  /// <summary>
  ///   StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public BorderType? StartBorder { get; set; }

  /// <summary>
  ///   Table Cell Bottom Border.
  /// </summary>
  public BorderType? BottomBorder { get; set; }

  /// <summary>
  ///   Table Cell Right Border.
  /// </summary>
  public BorderType? RightBorder { get; set; }

  /// <summary>
  ///   EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public BorderType? EndBorder { get; set; }

  /// <summary>
  ///   Table Cell Inside Horizontal Edges Border.
  /// </summary>
  public BorderType? InsideHorizontalBorder { get; set; }

  /// <summary>
  ///   Table Cell Inside Vertical Edges Border.
  /// </summary>
  public BorderType? InsideVerticalBorder { get; set; }

  /// <summary>
  ///   Table Cell Top Left to Bottom Right Diagonal Border.
  /// </summary>
  public BorderType? TopLeftToBottomRightCellBorder { get; set; }

  /// <summary>
  ///   Table Cell Top Right to Bottom Left Diagonal Border.
  /// </summary>
  public BorderType? TopRightToBottomLeftCellBorder { get; set; }
}