namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableCellMarginDefault Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITopMargin))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IStartMargin))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBottomMargin))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEndMargin))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCellLeftMargin))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCellRightMargin))]
public class TableCellMarginDefault: ITableCellMarginDefault
{
  /// <summary>
  /// Table Cell Top Margin Default.
  /// </summary>
  public ITopMargin? TopMargin
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Cell Left Margin Default.
  /// </summary>
  public ITableCellLeftMargin? TableCellLeftMargin
  {
    get;
    set;
  }
  
  /// <summary>
  /// StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public IStartMargin? StartMargin
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Cell Bottom Margin Default.
  /// </summary>
  public IBottomMargin? BottomMargin
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Cell Right Margin Default.
  /// </summary>
  public ITableCellRightMargin? TableCellRightMargin
  {
    get;
    set;
  }
  
  /// <summary>
  /// EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public IEndMargin? EndMargin
  {
    get;
    set;
  }
  
}
