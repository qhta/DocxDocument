namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of cell margins for all cells in the parent table row via a set of table-level property exceptions. These settings can be overridden by the table cell margin definition specified by the tcMar element contained within the table cell's properties.
/// </summary>
public partial class TableCellMarginDefault
{
  
  /// <summary>
  ///   Table Cell Top Margin Default.
  /// </summary>
  public DMW.TopMargin? TopMargin { get; set; }
  
  
  /// <summary>
  ///   Table Cell Left Margin Default.
  /// </summary>
  public DMW.TableCellLeftMargin? TableCellLeftMargin { get; set; }
  
  
  /// <summary>
  ///   StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public DMW.StartMargin? StartMargin { get; set; }
  
  
  /// <summary>
  ///   Table Cell Bottom Margin Default.
  /// </summary>
  public DMW.BottomMargin? BottomMargin { get; set; }
  
  
  /// <summary>
  ///   Table Cell Right Margin Default.
  /// </summary>
  public DMW.TableCellRightMargin? TableCellRightMargin { get; set; }
  
  
  /// <summary>
  ///   EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public DMW.EndMargin? EndMargin { get; set; }
  
}
