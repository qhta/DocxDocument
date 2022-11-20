namespace DocumentModel.Spreadsheet;

/// <summary>
/// Revision Merge Conflict.
/// </summary>
public class RevisionConflict: IRevisionConflict
{
  /// <summary>
  /// Revision Id
  /// </summary>
  public uint? RevisionId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Revision From Rejection
  /// </summary>
  public bool? Ua
  {
    get;
    set;
  }
  
  /// <summary>
  /// Revision Undo Rejected
  /// </summary>
  public bool? Ra
  {
    get;
    set;
  }
  
  /// <summary>
  /// Sheet Id
  /// </summary>
  public uint? SheetId
  {
    get;
    set;
  }
  
}
