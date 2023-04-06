namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TableCellMargin Class.
/// </summary>
public class TableCellMargin: ModelElement
{
  /// <summary>
  ///   Table Cell Top Margin Exception.
  /// </summary>
  public TableWidth? TopMargin { get; set; }

  /// <summary>
  ///   Table Cell Left Margin Exception.
  /// </summary>
  public TableWidth? LeftMargin { get; set; }

  /// <summary>
  ///   StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public TableWidth? StartMargin { get; set; }

  /// <summary>
  ///   Table Cell Bottom Margin Exception.
  /// </summary>
  public TableWidth? BottomMargin { get; set; }

  /// <summary>
  ///   Table Cell Right Margin Exception.
  /// </summary>
  public TableWidth? RightMargin { get; set; }

  /// <summary>
  ///   EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public TableWidth? EndMargin { get; set; }
}