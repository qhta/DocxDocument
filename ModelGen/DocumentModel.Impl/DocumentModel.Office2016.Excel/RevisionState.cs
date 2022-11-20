namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the RevisionState Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IFreezePanes))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IHideUnhideSheet))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IOutlines))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRowColVisualOps))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IShowGridlinesHeadings))]
public class RevisionState: IRevisionState
{
  /// <summary>
  /// RowColVisualOps.
  /// </summary>
  public IRowColVisualOps? RowColVisualOps
  {
    get;
    set;
  }
  
  /// <summary>
  /// HideUnhideSheet.
  /// </summary>
  public IHideUnhideSheet? HideUnhideSheet
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShowGridlinesHeadings.
  /// </summary>
  public IShowGridlinesHeadings? ShowGridlinesHeadings
  {
    get;
    set;
  }
  
  /// <summary>
  /// FreezePanes.
  /// </summary>
  public IFreezePanes? FreezePanes
  {
    get;
    set;
  }
  
  /// <summary>
  /// Outlines.
  /// </summary>
  public IOutlines? Outlines
  {
    get;
    set;
  }
  
}
