namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TableCellMarginDefault Class.
/// </summary>
public class TableCellMarginDefault: ModelElement
{
  /// <summary>
  ///   Table Cell Top Margin Default.
  /// </summary>
  public TableWidth? TopMargin { get; set; }

  /// <summary>
  ///   Table Cell Left Margin Default.
  /// </summary>
  public TableWidth? TableCellLeftMargin { get; set; }

  /// <summary>
  ///   StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public TableWidth? StartMargin { get; set; }

  /// <summary>
  ///   Table Cell Bottom Margin Default.
  /// </summary>
  public TableWidth? BottomMargin { get; set; }

  /// <summary>
  ///   Table Cell Right Margin Default.
  /// </summary>
  public TableWidth? TableCellRightMargin { get; set; }

  /// <summary>
  ///   EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public TableWidth? EndMargin { get; set; }
}