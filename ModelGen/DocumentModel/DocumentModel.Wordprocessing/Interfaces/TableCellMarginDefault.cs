namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableCellMarginDefault Class.
/// </summary>
public interface TableCellMarginDefault
{
  /// <summary>
  /// Table Cell Top Margin Default.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? TopMargin { get ; set; }
  
  /// <summary>
  /// Table Cell Left Margin Default.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthDxaNilType? TableCellLeftMargin { get ; set; }
  
  /// <summary>
  /// StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? StartMargin { get ; set; }
  
  /// <summary>
  /// Table Cell Bottom Margin Default.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? BottomMargin { get ; set; }
  
  /// <summary>
  /// Table Cell Right Margin Default.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthDxaNilType? TableCellRightMargin { get ; set; }
  
  /// <summary>
  /// EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? EndMargin { get ; set; }
  
}
