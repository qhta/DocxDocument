namespace DocumentModel.Spreadsheet;

/// <summary>
/// Cell Style.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
public class CellStyle: ICellStyle
{
  /// <summary>
  /// User Defined Cell Style
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Format Id
  /// </summary>
  public uint? FormatId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Built-In Style Id
  /// </summary>
  public uint? BuiltinId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Outline Style
  /// </summary>
  public uint? OutlineLevel
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hidden Style
  /// </summary>
  public bool? Hidden
  {
    get;
    set;
  }
  
  /// <summary>
  /// Custom Built In
  /// </summary>
  public bool? CustomBuiltin
  {
    get;
    set;
  }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
