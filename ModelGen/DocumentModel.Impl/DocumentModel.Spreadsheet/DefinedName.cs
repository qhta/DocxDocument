namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defined Name.
/// </summary>
public class DefinedName: IDefinedName
{
  /// <summary>
  /// Defined Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Comment
  /// </summary>
  public string? Comment
  {
    get;
    set;
  }
  
  /// <summary>
  /// Custom Menu Text
  /// </summary>
  public string? CustomMenu
  {
    get;
    set;
  }
  
  /// <summary>
  /// Description
  /// </summary>
  public string? Description
  {
    get;
    set;
  }
  
  /// <summary>
  /// Help
  /// </summary>
  public string? Help
  {
    get;
    set;
  }
  
  /// <summary>
  /// Status Bar
  /// </summary>
  public string? StatusBar
  {
    get;
    set;
  }
  
  /// <summary>
  /// Local Name Sheet Id
  /// </summary>
  public uint? LocalSheetId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hidden Name
  /// </summary>
  public bool? Hidden
  {
    get;
    set;
  }
  
  /// <summary>
  /// Function
  /// </summary>
  public bool? Function
  {
    get;
    set;
  }
  
  /// <summary>
  /// Procedure
  /// </summary>
  public bool? VbProcedure
  {
    get;
    set;
  }
  
  /// <summary>
  /// External Function
  /// </summary>
  public bool? Xlm
  {
    get;
    set;
  }
  
  /// <summary>
  /// Function Group Id
  /// </summary>
  public uint? FunctionGroupId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shortcut Key
  /// </summary>
  public string? ShortcutKey
  {
    get;
    set;
  }
  
  /// <summary>
  /// Publish To Server
  /// </summary>
  public bool? PublishToServer
  {
    get;
    set;
  }
  
  /// <summary>
  /// Workbook Parameter (Server)
  /// </summary>
  public bool? WorkbookParameter
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text
  {
    get;
    set;
  }
  
}
