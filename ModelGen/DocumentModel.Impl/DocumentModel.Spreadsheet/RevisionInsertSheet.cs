namespace DocumentModel.Spreadsheet;

/// <summary>
/// Revision Insert Sheet.
/// </summary>
public class RevisionInsertSheet: IRevisionInsertSheet
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
  
  /// <summary>
  /// Sheet Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Sheet Position
  /// </summary>
  public uint? SheetPosition
  {
    get;
    set;
  }
  
}
