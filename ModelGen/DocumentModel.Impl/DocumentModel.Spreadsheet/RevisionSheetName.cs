namespace DocumentModel.Spreadsheet;

/// <summary>
/// Revision Sheet Name.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
public class RevisionSheetName: IRevisionSheetName
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
  /// Old Sheet Name
  /// </summary>
  public string? OldName
  {
    get;
    set;
  }
  
  /// <summary>
  /// New Sheet Name
  /// </summary>
  public string? NewName
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
