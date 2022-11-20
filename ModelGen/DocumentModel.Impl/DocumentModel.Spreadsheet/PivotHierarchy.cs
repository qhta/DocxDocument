namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Hierarchy.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMemberProperties))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMembers))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotHierarchyExtensionList))]
public class PivotHierarchy: IPivotHierarchy
{
  /// <summary>
  /// Outline New Levels
  /// </summary>
  public bool? Outline
  {
    get;
    set;
  }
  
  /// <summary>
  /// Multiple Field Filters
  /// </summary>
  public bool? MultipleItemSelectionAllowed
  {
    get;
    set;
  }
  
  /// <summary>
  /// New Levels Subtotals At Top
  /// </summary>
  public bool? SubtotalTop
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show In Field List
  /// </summary>
  public bool? ShowInFieldList
  {
    get;
    set;
  }
  
  /// <summary>
  /// Drag To Row
  /// </summary>
  public bool? DragToRow
  {
    get;
    set;
  }
  
  /// <summary>
  /// Drag To Column
  /// </summary>
  public bool? DragToColumn
  {
    get;
    set;
  }
  
  /// <summary>
  /// Drag to Page
  /// </summary>
  public bool? DragToPage
  {
    get;
    set;
  }
  
  /// <summary>
  /// Drag To Data
  /// </summary>
  public bool? DragToData
  {
    get;
    set;
  }
  
  /// <summary>
  /// Drag Off
  /// </summary>
  public bool? DragOff
  {
    get;
    set;
  }
  
  /// <summary>
  /// Inclusive Manual Filter
  /// </summary>
  public bool? IncludeNewItemsInFilter
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hierarchy Caption
  /// </summary>
  public string? Caption
  {
    get;
    set;
  }
  
  /// <summary>
  /// OLAP Member Properties.
  /// </summary>
  public IMemberProperties? MemberProperties
  {
    get;
    set;
  }
  
}
