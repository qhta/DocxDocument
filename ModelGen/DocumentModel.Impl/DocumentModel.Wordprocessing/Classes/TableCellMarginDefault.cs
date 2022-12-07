namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableCellMarginDefault Class.
/// </summary>
public class TableCellMarginDefaultImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault>, TableCellMarginDefault
{
  /// <summary>
  /// Table Cell Top Margin Default.
  /// </summary>
  public TableWidthType? TopMargin
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Cell Left Margin Default.
  /// </summary>
  public TableWidthDxaNilType? TableCellLeftMargin
  {
    get;
    set;
  }
  
  /// <summary>
  /// StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public TableWidthType? StartMargin
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Cell Bottom Margin Default.
  /// </summary>
  public TableWidthType? BottomMargin
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Cell Right Margin Default.
  /// </summary>
  public TableWidthDxaNilType? TableCellRightMargin
  {
    get;
    set;
  }
  
  /// <summary>
  /// EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public TableWidthType? EndMargin
  {
    get;
    set;
  }
  
}
