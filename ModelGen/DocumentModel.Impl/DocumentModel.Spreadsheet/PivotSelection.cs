namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotTable Selection.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotArea))]
public class PivotSelection: IPivotSelection
{
  /// <summary>
  /// Pane
  /// </summary>
  public PaneValues? Pane
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show Header
  /// </summary>
  public bool? ShowHeader
  {
    get;
    set;
  }
  
  /// <summary>
  /// Label
  /// </summary>
  public bool? Label
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data Selection
  /// </summary>
  public bool? Data
  {
    get;
    set;
  }
  
  /// <summary>
  /// Extendable
  /// </summary>
  public bool? Extendable
  {
    get;
    set;
  }
  
  /// <summary>
  /// Selection Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
  /// <summary>
  /// Axis
  /// </summary>
  public PivotTableAxisValues? Axis
  {
    get;
    set;
  }
  
  /// <summary>
  /// Dimension
  /// </summary>
  public uint? Dimension
  {
    get;
    set;
  }
  
  /// <summary>
  /// Start
  /// </summary>
  public uint? Start
  {
    get;
    set;
  }
  
  /// <summary>
  /// Minimum
  /// </summary>
  public uint? Min
  {
    get;
    set;
  }
  
  /// <summary>
  /// Maximum
  /// </summary>
  public uint? Max
  {
    get;
    set;
  }
  
  /// <summary>
  /// Active Row
  /// </summary>
  public uint? ActiveRow
  {
    get;
    set;
  }
  
  /// <summary>
  /// Active Column
  /// </summary>
  public uint? ActiveColumn
  {
    get;
    set;
  }
  
  /// <summary>
  /// Previous Row
  /// </summary>
  public uint? PreviousRow
  {
    get;
    set;
  }
  
  /// <summary>
  /// Previous Column Selection
  /// </summary>
  public uint? PreviousColumn
  {
    get;
    set;
  }
  
  /// <summary>
  /// Click Count
  /// </summary>
  public uint? Click
  {
    get;
    set;
  }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Pivot Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotArea? PivotArea
  {
    get;
    set;
  }
  
}
