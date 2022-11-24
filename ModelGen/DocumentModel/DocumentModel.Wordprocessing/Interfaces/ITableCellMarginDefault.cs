namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableCellMarginDefault Class.
/// </summary>
public interface ITableCellMarginDefault // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Table Cell Top Margin Default.
  /// </summary>
  public ITopMargin? TopMargin { get ; set; }
  
  /// <summary>
  /// Table Cell Left Margin Default.
  /// </summary>
  public ITableCellLeftMargin? TableCellLeftMargin { get ; set; }
  
  /// <summary>
  /// StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public IStartMargin? StartMargin { get ; set; }
  
  /// <summary>
  /// Table Cell Bottom Margin Default.
  /// </summary>
  public IBottomMargin? BottomMargin { get ; set; }
  
  /// <summary>
  /// Table Cell Right Margin Default.
  /// </summary>
  public ITableCellRightMargin? TableCellRightMargin { get ; set; }
  
  /// <summary>
  /// EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public IEndMargin? EndMargin { get ; set; }
  
}
