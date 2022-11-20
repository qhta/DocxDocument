namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sheet Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITabColor))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IOutlineProperties))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPageSetupProperties))]
public class SheetProperties: ISheetProperties
{
  /// <summary>
  /// Synch Horizontal
  /// </summary>
  public bool? SyncHorizontal
  {
    get;
    set;
  }
  
  /// <summary>
  /// Synch Vertical
  /// </summary>
  public bool? SyncVertical
  {
    get;
    set;
  }
  
  /// <summary>
  /// Synch Reference
  /// </summary>
  public string? SyncReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Transition Formula Evaluation
  /// </summary>
  public bool? TransitionEvaluation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Transition Formula Entry
  /// </summary>
  public bool? TransitionEntry
  {
    get;
    set;
  }
  
  /// <summary>
  /// Published
  /// </summary>
  public bool? Published
  {
    get;
    set;
  }
  
  /// <summary>
  /// Code Name
  /// </summary>
  public string? CodeName
  {
    get;
    set;
  }
  
  /// <summary>
  /// Filter Mode
  /// </summary>
  public bool? FilterMode
  {
    get;
    set;
  }
  
  /// <summary>
  /// Enable Conditional Formatting Calculations
  /// </summary>
  public bool? EnableFormatConditionsCalculation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Sheet Tab Color.
  /// </summary>
  public ITabColor? TabColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Outline Properties.
  /// </summary>
  public IOutlineProperties? OutlineProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Page Setup Properties.
  /// </summary>
  public IPageSetupProperties? PageSetupProperties
  {
    get;
    set;
  }
  
}
