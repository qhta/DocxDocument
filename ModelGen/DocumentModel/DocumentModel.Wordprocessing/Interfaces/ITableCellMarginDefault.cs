namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableCellMarginDefault Class.
/// </summary>
public interface ITableCellMarginDefault // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Table Cell Top Margin Default.
  /// </summary>
  public ITableWidthType? TopMargin { get ; set; }
  
  /// <summary>
  /// Table Cell Left Margin Default.
  /// </summary>
  public ITableWidthDxaNilType? TableCellLeftMargin { get ; set; }
  
  /// <summary>
  /// StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public ITableWidthType? StartMargin { get ; set; }
  
  /// <summary>
  /// Table Cell Bottom Margin Default.
  /// </summary>
  public ITableWidthType? BottomMargin { get ; set; }
  
  /// <summary>
  /// Table Cell Right Margin Default.
  /// </summary>
  public ITableWidthDxaNilType? TableCellRightMargin { get ; set; }
  
  /// <summary>
  /// EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public ITableWidthType? EndMargin { get ; set; }
  
}
