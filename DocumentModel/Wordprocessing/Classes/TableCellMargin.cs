namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TableCellMargin Class.
/// </summary>
public class TableCellMargin
{
  /// <summary>
  ///   Table Cell Top Margin Exception.
  /// </summary>
  public TableWidthType? TopMargin { get; set; }

  /// <summary>
  ///   Table Cell Left Margin Exception.
  /// </summary>
  public TableWidthType? LeftMargin { get; set; }

  /// <summary>
  ///   StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public TableWidthType? StartMargin { get; set; }

  /// <summary>
  ///   Table Cell Bottom Margin Exception.
  /// </summary>
  public TableWidthType? BottomMargin { get; set; }

  /// <summary>
  ///   Table Cell Right Margin Exception.
  /// </summary>
  public TableWidthType? RightMargin { get; set; }

  /// <summary>
  ///   EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public TableWidthType? EndMargin { get; set; }
}