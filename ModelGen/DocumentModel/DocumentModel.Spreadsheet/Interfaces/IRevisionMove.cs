namespace DocumentModel.Spreadsheet;

/// <summary>
/// Revision Cell Move.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRevisionCellChange))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRevisionFormat))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IUndo))]
public interface IRevisionMove // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  /// Source
  /// </summary>
  public string? Source { get ; set; }
  
  /// <summary>
  /// Destination
  /// </summary>
  public string? Destination { get ; set; }
  
  /// <summary>
  /// Source Sheet Id
  /// </summary>
  public uint? SourceSheetId { get ; set; }
  
}
