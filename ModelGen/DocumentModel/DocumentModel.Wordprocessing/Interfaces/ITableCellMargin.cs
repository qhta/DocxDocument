namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableCellMargin Class.
/// </summary>
public interface ITableCellMargin // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Table Cell Top Margin Exception.
  /// </summary>
  public ITopMargin? TopMargin { get ; set; }
  
  /// <summary>
  /// Table Cell Left Margin Exception.
  /// </summary>
  public ILeftMargin? LeftMargin { get ; set; }
  
  /// <summary>
  /// StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public IStartMargin? StartMargin { get ; set; }
  
  /// <summary>
  /// Table Cell Bottom Margin Exception.
  /// </summary>
  public IBottomMargin? BottomMargin { get ; set; }
  
  /// <summary>
  /// Table Cell Right Margin Exception.
  /// </summary>
  public IRightMargin? RightMargin { get ; set; }
  
  /// <summary>
  /// EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public IEndMargin? EndMargin { get ; set; }
  
}
