namespace DocumentModel.Spreadsheet;

/// <summary>
/// Custom Workbook View.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
public class CustomWorkbookView: ICustomWorkbookView
{
  /// <summary>
  /// Custom View Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Custom View GUID
  /// </summary>
  public string? Guid
  {
    get;
    set;
  }
  
  /// <summary>
  /// Auto Update
  /// </summary>
  public bool? AutoUpdate
  {
    get;
    set;
  }
  
  /// <summary>
  /// Merge Interval
  /// </summary>
  public uint? MergeInterval
  {
    get;
    set;
  }
  
  /// <summary>
  /// Changes Saved Win
  /// </summary>
  public bool? ChangesSavedWin
  {
    get;
    set;
  }
  
  /// <summary>
  /// Only Synch
  /// </summary>
  public bool? OnlySync
  {
    get;
    set;
  }
  
  /// <summary>
  /// Personal View
  /// </summary>
  public bool? PersonalView
  {
    get;
    set;
  }
  
  /// <summary>
  /// Include Print Settings
  /// </summary>
  public bool? IncludePrintSettings
  {
    get;
    set;
  }
  
  /// <summary>
  /// Include Hidden Rows and Columns
  /// </summary>
  public bool? IncludeHiddenRowColumn
  {
    get;
    set;
  }
  
  /// <summary>
  /// Maximized
  /// </summary>
  public bool? Maximized
  {
    get;
    set;
  }
  
  /// <summary>
  /// Minimized
  /// </summary>
  public bool? Minimized
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show Horizontal Scroll
  /// </summary>
  public bool? ShowHorizontalScroll
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show Vertical Scroll
  /// </summary>
  public bool? ShowVerticalScroll
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show Sheet Tabs
  /// </summary>
  public bool? ShowSheetTabs
  {
    get;
    set;
  }
  
  /// <summary>
  /// Top Left Corner (X Coordinate)
  /// </summary>
  public int? XWindow
  {
    get;
    set;
  }
  
  /// <summary>
  /// Top Left Corner (Y Coordinate)
  /// </summary>
  public int? YWindow
  {
    get;
    set;
  }
  
  /// <summary>
  /// Window Width
  /// </summary>
  public uint? WindowWidth
  {
    get;
    set;
  }
  
  /// <summary>
  /// Window Height
  /// </summary>
  public uint? WindowHeight
  {
    get;
    set;
  }
  
  /// <summary>
  /// Sheet Tab Ratio
  /// </summary>
  public uint? TabRatio
  {
    get;
    set;
  }
  
  /// <summary>
  /// Active Sheet in Book View
  /// </summary>
  public uint? ActiveSheetId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show Formula Bar
  /// </summary>
  public bool? ShowFormulaBar
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show Status Bar
  /// </summary>
  public bool? ShowStatusbar
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show Comments
  /// </summary>
  public CommentsValues? ShowComments
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show Objects
  /// </summary>
  public ObjectDisplayValues? ShowObjects
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
