namespace DocumentModel.Spreadsheet;

/// <summary>
/// Connection.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IConnectionExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDatabaseProperties))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IOlapProperties))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IParameters))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITextProperties))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IWebQueryProperties))]
public class Connection: IConnection
{
  /// <summary>
  /// id
  /// </summary>
  public uint? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// sourceFile
  /// </summary>
  public string? SourceFile
  {
    get;
    set;
  }
  
  /// <summary>
  /// odcFile
  /// </summary>
  public string? ConnectionFile
  {
    get;
    set;
  }
  
  /// <summary>
  /// keepAlive
  /// </summary>
  public bool? KeepAlive
  {
    get;
    set;
  }
  
  /// <summary>
  /// interval
  /// </summary>
  public uint? Interval
  {
    get;
    set;
  }
  
  /// <summary>
  /// name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// description
  /// </summary>
  public string? Description
  {
    get;
    set;
  }
  
  /// <summary>
  /// type
  /// </summary>
  public uint? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// reconnectionMethod
  /// </summary>
  public uint? ReconnectionMethod
  {
    get;
    set;
  }
  
  /// <summary>
  /// refreshedVersion
  /// </summary>
  public byte? RefreshedVersion
  {
    get;
    set;
  }
  
  /// <summary>
  /// minRefreshableVersion
  /// </summary>
  public byte? MinRefreshableVersion
  {
    get;
    set;
  }
  
  /// <summary>
  /// savePassword
  /// </summary>
  public bool? SavePassword
  {
    get;
    set;
  }
  
  /// <summary>
  /// new
  /// </summary>
  public bool? New
  {
    get;
    set;
  }
  
  /// <summary>
  /// deleted
  /// </summary>
  public bool? Deleted
  {
    get;
    set;
  }
  
  /// <summary>
  /// onlyUseConnectionFile
  /// </summary>
  public bool? OnlyUseConnectionFile
  {
    get;
    set;
  }
  
  /// <summary>
  /// background
  /// </summary>
  public bool? Background
  {
    get;
    set;
  }
  
  /// <summary>
  /// refreshOnLoad
  /// </summary>
  public bool? RefreshOnLoad
  {
    get;
    set;
  }
  
  /// <summary>
  /// saveData
  /// </summary>
  public bool? SaveData
  {
    get;
    set;
  }
  
  /// <summary>
  /// credentials
  /// </summary>
  public CredentialsMethodValues? Credentials
  {
    get;
    set;
  }
  
  /// <summary>
  /// singleSignOnId
  /// </summary>
  public string? SingleSignOnId
  {
    get;
    set;
  }
  
  /// <summary>
  /// DatabaseProperties.
  /// </summary>
  public IDatabaseProperties? DatabaseProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// OlapProperties.
  /// </summary>
  public IOlapProperties? OlapProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// WebQueryProperties.
  /// </summary>
  public IWebQueryProperties? WebQueryProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public DocumentModel.Spreadsheet.ITextProperties? TextProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Parameters.
  /// </summary>
  public IParameters? Parameters
  {
    get;
    set;
  }
  
  /// <summary>
  /// ConnectionExtensionList.
  /// </summary>
  public IConnectionExtensionList? ConnectionExtensionList
  {
    get;
    set;
  }
  
}
