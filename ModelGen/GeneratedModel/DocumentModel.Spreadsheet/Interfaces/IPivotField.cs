namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotTable Field.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IAutoSortScope))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IItems))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotFieldExtensionList))]
public interface IPivotField // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// Axis
  /// </summary>
  public PivotTableAxis? Axis { get ; set; }
  
  /// <summary>
  /// Data Field
  /// </summary>
  public bool? DataField { get ; set; }
  
  /// <summary>
  /// Custom Subtotal Caption
  /// </summary>
  public string? SubtotalCaption { get ; set; }
  
  /// <summary>
  /// Show PivotField Header Drop Downs
  /// </summary>
  public bool? ShowDropDowns { get ; set; }
  
  /// <summary>
  /// Hidden Level
  /// </summary>
  public bool? HiddenLevel { get ; set; }
  
  /// <summary>
  /// Unique Member Property
  /// </summary>
  public string? UniqueMemberProperty { get ; set; }
  
  /// <summary>
  /// Compact
  /// </summary>
  public bool? Compact { get ; set; }
  
  /// <summary>
  /// All Items Expanded
  /// </summary>
  public bool? AllDrilled { get ; set; }
  
  /// <summary>
  /// Number Format Id
  /// </summary>
  public uint? NumberFormatId { get ; set; }
  
  /// <summary>
  /// Outline Items
  /// </summary>
  public bool? Outline { get ; set; }
  
  /// <summary>
  /// Subtotals At Top
  /// </summary>
  public bool? SubtotalTop { get ; set; }
  
  /// <summary>
  /// Drag To Row
  /// </summary>
  public bool? DragToRow { get ; set; }
  
  /// <summary>
  /// Drag To Column
  /// </summary>
  public bool? DragToColumn { get ; set; }
  
  /// <summary>
  /// Multiple Field Filters
  /// </summary>
  public bool? MultipleItemSelectionAllowed { get ; set; }
  
  /// <summary>
  /// Drag Field to Page
  /// </summary>
  public bool? DragToPage { get ; set; }
  
  /// <summary>
  /// Field Can Drag to Data
  /// </summary>
  public bool? DragToData { get ; set; }
  
  /// <summary>
  /// Drag Off
  /// </summary>
  public bool? DragOff { get ; set; }
  
  /// <summary>
  /// Show All Items
  /// </summary>
  public bool? ShowAll { get ; set; }
  
  /// <summary>
  /// Insert Blank Row
  /// </summary>
  public bool? InsertBlankRow { get ; set; }
  
  /// <summary>
  /// Server-based Page Field
  /// </summary>
  public bool? ServerField { get ; set; }
  
  /// <summary>
  /// Insert Item Page Break
  /// </summary>
  public bool? InsertPageBreak { get ; set; }
  
  /// <summary>
  /// Auto Show
  /// </summary>
  public bool? AutoShow { get ; set; }
  
  /// <summary>
  /// Top Auto Show
  /// </summary>
  public bool? TopAutoShow { get ; set; }
  
  /// <summary>
  /// Hide New Items
  /// </summary>
  public bool? HideNewItems { get ; set; }
  
  /// <summary>
  /// Measure Filter
  /// </summary>
  public bool? MeasureFilter { get ; set; }
  
  /// <summary>
  /// Inclusive Manual Filter
  /// </summary>
  public bool? IncludeNewItemsInFilter { get ; set; }
  
  /// <summary>
  /// Items Per Page Count
  /// </summary>
  public uint? ItemPageCount { get ; set; }
  
  /// <summary>
  /// Auto Sort Type
  /// </summary>
  public FieldSort? SortType { get ; set; }
  
  /// <summary>
  /// Data Source Sort
  /// </summary>
  public bool? DataSourceSort { get ; set; }
  
  /// <summary>
  /// Auto Sort
  /// </summary>
  public bool? NonAutoSortDefault { get ; set; }
  
  /// <summary>
  /// Auto Show Rank By
  /// </summary>
  public uint? RankBy { get ; set; }
  
  /// <summary>
  /// Show Default Subtotal
  /// </summary>
  public bool? DefaultSubtotal { get ; set; }
  
  /// <summary>
  /// Sum Subtotal
  /// </summary>
  public bool? SumSubtotal { get ; set; }
  
  /// <summary>
  /// CountA
  /// </summary>
  public bool? CountASubtotal { get ; set; }
  
  /// <summary>
  /// Average
  /// </summary>
  public bool? AverageSubTotal { get ; set; }
  
  /// <summary>
  /// Max Subtotal
  /// </summary>
  public bool? MaxSubtotal { get ; set; }
  
  /// <summary>
  /// Min Subtotal
  /// </summary>
  public bool? MinSubtotal { get ; set; }
  
  /// <summary>
  /// Product Subtotal
  /// </summary>
  public bool? ApplyProductInSubtotal { get ; set; }
  
  /// <summary>
  /// Count
  /// </summary>
  public bool? CountSubtotal { get ; set; }
  
  /// <summary>
  /// StdDev Subtotal
  /// </summary>
  public bool? ApplyStandardDeviationInSubtotal { get ; set; }
  
  /// <summary>
  /// StdDevP Subtotal
  /// </summary>
  public bool? ApplyStandardDeviationPInSubtotal { get ; set; }
  
  /// <summary>
  /// Variance Subtotal
  /// </summary>
  public bool? ApplyVarianceInSubtotal { get ; set; }
  
  /// <summary>
  /// VarP Subtotal
  /// </summary>
  public bool? ApplyVariancePInSubtotal { get ; set; }
  
  /// <summary>
  /// Show Member Property in Cell
  /// </summary>
  public bool? ShowPropCell { get ; set; }
  
  /// <summary>
  /// Show Member Property ToolTip
  /// </summary>
  public bool? ShowPropertyTooltip { get ; set; }
  
  /// <summary>
  /// Show As Caption
  /// </summary>
  public bool? ShowPropAsCaption { get ; set; }
  
  /// <summary>
  /// Drill State
  /// </summary>
  public bool? DefaultAttributeDrillState { get ; set; }
  
  /// <summary>
  /// Field Items.
  /// </summary>
  public IItems? Items { get ; set; }
  
  /// <summary>
  /// AutoSort Scope.
  /// </summary>
  public IAutoSortScope? AutoSortScope { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public IPivotFieldExtensionList? PivotFieldExtensionList { get ; set; }
  
}
