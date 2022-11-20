namespace DocumentModel.Spreadsheet;

/// <summary>
/// User Information.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
public class UserInfo: IUserInfo
{
  /// <summary>
  /// User Revisions GUID
  /// </summary>
  public string? Guid
  {
    get;
    set;
  }
  
  /// <summary>
  /// User Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// User Id
  /// </summary>
  public int? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Date Time
  /// </summary>
  public DateTime? DateTime
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
