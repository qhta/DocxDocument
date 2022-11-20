namespace DocumentModel.Spreadsheet;

/// <summary>
/// Revision Cell Comment.
/// </summary>
public class RevisionComment: IRevisionComment
{
  /// <summary>
  /// Sheet Id
  /// </summary>
  public uint? SheetId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Cell
  /// </summary>
  public string? Cell
  {
    get;
    set;
  }
  
  /// <summary>
  /// GUID
  /// </summary>
  public string? Guid
  {
    get;
    set;
  }
  
  /// <summary>
  /// User Action
  /// </summary>
  public RevisionActionValues? Action
  {
    get;
    set;
  }
  
  /// <summary>
  /// Always Show Comment
  /// </summary>
  public bool? AlwaysShow
  {
    get;
    set;
  }
  
  /// <summary>
  /// Old Comment
  /// </summary>
  public bool? Old
  {
    get;
    set;
  }
  
  /// <summary>
  /// Comment In Hidden Row
  /// </summary>
  public bool? HiddenRow
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hidden Column
  /// </summary>
  public bool? HiddenColumn
  {
    get;
    set;
  }
  
  /// <summary>
  /// Author
  /// </summary>
  public string? Author
  {
    get;
    set;
  }
  
  /// <summary>
  /// Original Comment Length
  /// </summary>
  public uint? OldLength
  {
    get;
    set;
  }
  
  /// <summary>
  /// New Comment Length
  /// </summary>
  public uint? NewLength
  {
    get;
    set;
  }
  
}
