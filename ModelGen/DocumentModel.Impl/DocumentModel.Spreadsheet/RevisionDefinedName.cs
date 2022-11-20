namespace DocumentModel.Spreadsheet;

/// <summary>
/// Revision Defined Name.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFormula))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IOldFormula))]
public class RevisionDefinedName: IRevisionDefinedName
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
  /// Local Name Sheet Id
  /// </summary>
  public uint? LocalSheetId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Custom View
  /// </summary>
  public bool? CustomView
  {
    get;
    set;
  }
  
  /// <summary>
  /// Name
  /// </summary>
  public string? Name
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
  /// Old Function
  /// </summary>
  public bool? OldFunction
  {
    get;
    set;
  }
  
  /// <summary>
  /// Function Group Id
  /// </summary>
  public byte? FunctionGroupId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Old Function Group Id
  /// </summary>
  public byte? OldFunctionGroupId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shortcut Key
  /// </summary>
  public byte? ShortcutKey
  {
    get;
    set;
  }
  
  /// <summary>
  /// Old Short Cut Key
  /// </summary>
  public byte? OldShortcutKey
  {
    get;
    set;
  }
  
  /// <summary>
  /// Named Range Hidden
  /// </summary>
  public bool? Hidden
  {
    get;
    set;
  }
  
  /// <summary>
  /// Old Hidden
  /// </summary>
  public bool? OldHidden
  {
    get;
    set;
  }
  
  /// <summary>
  /// New Custom Menu
  /// </summary>
  public string? CustomMenu
  {
    get;
    set;
  }
  
  /// <summary>
  /// Old Custom Menu Text
  /// </summary>
  public string? OldCustomMenu
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
  /// Old Description
  /// </summary>
  public string? OldDescription
  {
    get;
    set;
  }
  
  /// <summary>
  /// New Help Topic
  /// </summary>
  public string? Help
  {
    get;
    set;
  }
  
  /// <summary>
  /// Old Help Topic
  /// </summary>
  public string? OldHelp
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
  /// Old Status Bar
  /// </summary>
  public string? OldStatusBar
  {
    get;
    set;
  }
  
  /// <summary>
  /// Name Comment
  /// </summary>
  public string? Comment
  {
    get;
    set;
  }
  
  /// <summary>
  /// Old Name Comment
  /// </summary>
  public string? OldComment
  {
    get;
    set;
  }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public DocumentModel.Spreadsheet.IFormula? Formula
  {
    get;
    set;
  }
  
  /// <summary>
  /// Old Formula.
  /// </summary>
  public IOldFormula? OldFormula
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
