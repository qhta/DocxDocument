namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Hierarchy.
/// </summary>
public interface IPivotHierarchy // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Outline New Levels
  /// </summary>
  public System.Boolean? Outline { get ; set; }
  
  /// <summary>
  /// Multiple Field Filters
  /// </summary>
  public System.Boolean? MultipleItemSelectionAllowed { get ; set; }
  
  /// <summary>
  /// New Levels Subtotals At Top
  /// </summary>
  public System.Boolean? SubtotalTop { get ; set; }
  
  /// <summary>
  /// Show In Field List
  /// </summary>
  public System.Boolean? ShowInFieldList { get ; set; }
  
  /// <summary>
  /// Drag To Row
  /// </summary>
  public System.Boolean? DragToRow { get ; set; }
  
  /// <summary>
  /// Drag To Column
  /// </summary>
  public System.Boolean? DragToColumn { get ; set; }
  
  /// <summary>
  /// Drag to Page
  /// </summary>
  public System.Boolean? DragToPage { get ; set; }
  
  /// <summary>
  /// Drag To Data
  /// </summary>
  public System.Boolean? DragToData { get ; set; }
  
  /// <summary>
  /// Drag Off
  /// </summary>
  public System.Boolean? DragOff { get ; set; }
  
  /// <summary>
  /// Inclusive Manual Filter
  /// </summary>
  public System.Boolean? IncludeNewItemsInFilter { get ; set; }
  
  /// <summary>
  /// Hierarchy Caption
  /// </summary>
  public System.String? Caption { get ; set; }
  
  /// <summary>
  /// OLAP Member Properties.
  /// </summary>
  public DocumentModel.Spreadsheet.IMemberProperties? MemberProperties { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IMembers>? Memberses { get ; set; }
  
  public DocumentModel.Spreadsheet.IPivotHierarchyExtensionList? PivotHierarchyExtensionList { get ; set; }
  
}
