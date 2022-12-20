namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableCellMargin Class.
/// </summary>
public partial interface TableCellMargin
{
  /// <summary>
  /// Table Cell Top Margin Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? TopMargin { get; set; }
  
  /// <summary>
  /// Table Cell Left Margin Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? LeftMargin { get; set; }
  
  /// <summary>
  /// StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? StartMargin { get; set; }
  
  /// <summary>
  /// Table Cell Bottom Margin Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? BottomMargin { get; set; }
  
  /// <summary>
  /// Table Cell Right Margin Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? RightMargin { get; set; }
  
  /// <summary>
  /// EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? EndMargin { get; set; }
  
}
