namespace DocumentModel.Spreadsheet;

/// <summary>
/// Revision Row Column Insert Delete.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRevisionCellChange))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRevisionFormat))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IUndo))]
public interface IRevisionRowColumn // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Revision Id
  /// </summary>
  public uint? RevisionId { get ; set; }
  
  /// <summary>
  /// Revision From Rejection
  /// </summary>
  public bool? Ua { get ; set; }
  
  /// <summary>
  /// Revision Undo Rejected
  /// </summary>
  public bool? Ra { get ; set; }
  
  /// <summary>
  /// Sheet Id
  /// </summary>
  public uint? SheetId { get ; set; }
  
  /// <summary>
  /// End Of List
  /// </summary>
  public bool? EndOfList { get ; set; }
  
  /// <summary>
  /// Reference
  /// </summary>
  public string? Reference { get ; set; }
  
  /// <summary>
  /// User Action
  /// </summary>
  public RowColumnActionValues? Action { get ; set; }
  
  /// <summary>
  /// Edge Deleted
  /// </summary>
  public bool? Edge { get ; set; }
  
}
