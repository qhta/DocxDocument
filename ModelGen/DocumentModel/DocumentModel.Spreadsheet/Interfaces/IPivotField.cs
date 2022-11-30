namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotTable Field.
/// </summary>
public interface IPivotField // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Axis
  /// </summary>
  public DocumentModel.Spreadsheet.PivotTableAxisKind? Axis { get ; set; }
  
  /// <summary>
  /// Data Field
  /// </summary>
  public System.Boolean? DataField { get ; set; }
  
  /// <summary>
  /// Custom Subtotal Caption
  /// </summary>
  public System.String? SubtotalCaption { get ; set; }
  
  /// <summary>
  /// Show PivotField Header Drop Downs
  /// </summary>
  public System.Boolean? ShowDropDowns { get ; set; }
  
  /// <summary>
  /// Hidden Level
  /// </summary>
  public System.Boolean? HiddenLevel { get ; set; }
  
  /// <summary>
  /// Unique Member Property
  /// </summary>
  public System.String? UniqueMemberProperty { get ; set; }
  
  /// <summary>
  /// Compact
  /// </summary>
  public System.Boolean? Compact { get ; set; }
  
  /// <summary>
  /// All Items Expanded
  /// </summary>
  public System.Boolean? AllDrilled { get ; set; }
  
  /// <summary>
  /// Number Format Id
  /// </summary>
  public System.UInt32? NumberFormatId { get ; set; }
  
  /// <summary>
  /// Outline Items
  /// </summary>
  public System.Boolean? Outline { get ; set; }
  
  /// <summary>
  /// Subtotals At Top
  /// </summary>
  public System.Boolean? SubtotalTop { get ; set; }
  
  /// <summary>
  /// Drag To Row
  /// </summary>
  public System.Boolean? DragToRow { get ; set; }
  
  /// <summary>
  /// Drag To Column
  /// </summary>
  public System.Boolean? DragToColumn { get ; set; }
  
  /// <summary>
  /// Multiple Field Filters
  /// </summary>
  public System.Boolean? MultipleItemSelectionAllowed { get ; set; }
  
  /// <summary>
  /// Drag Field to Page
  /// </summary>
  public System.Boolean? DragToPage { get ; set; }
  
  /// <summary>
  /// Field Can Drag to Data
  /// </summary>
  public System.Boolean? DragToData { get ; set; }
  
  /// <summary>
  /// Drag Off
  /// </summary>
  public System.Boolean? DragOff { get ; set; }
  
  /// <summary>
  /// Show All Items
  /// </summary>
  public System.Boolean? ShowAll { get ; set; }
  
  /// <summary>
  /// Insert Blank Row
  /// </summary>
  public System.Boolean? InsertBlankRow { get ; set; }
  
  /// <summary>
  /// Server-based Page Field
  /// </summary>
  public System.Boolean? ServerField { get ; set; }
  
  /// <summary>
  /// Insert Item Page Break
  /// </summary>
  public System.Boolean? InsertPageBreak { get ; set; }
  
  /// <summary>
  /// Auto Show
  /// </summary>
  public System.Boolean? AutoShow { get ; set; }
  
  /// <summary>
  /// Top Auto Show
  /// </summary>
  public System.Boolean? TopAutoShow { get ; set; }
  
  /// <summary>
  /// Hide New Items
  /// </summary>
  public System.Boolean? HideNewItems { get ; set; }
  
  /// <summary>
  /// Measure Filter
  /// </summary>
  public System.Boolean? MeasureFilter { get ; set; }
  
  /// <summary>
  /// Inclusive Manual Filter
  /// </summary>
  public System.Boolean? IncludeNewItemsInFilter { get ; set; }
  
  /// <summary>
  /// Items Per Page Count
  /// </summary>
  public System.UInt32? ItemPageCount { get ; set; }
  
  /// <summary>
  /// Auto Sort Type
  /// </summary>
  public DocumentModel.Spreadsheet.FieldSortKind? SortType { get ; set; }
  
  /// <summary>
  /// Data Source Sort
  /// </summary>
  public System.Boolean? DataSourceSort { get ; set; }
  
  /// <summary>
  /// Auto Sort
  /// </summary>
  public System.Boolean? NonAutoSortDefault { get ; set; }
  
  /// <summary>
  /// Auto Show Rank By
  /// </summary>
  public System.UInt32? RankBy { get ; set; }
  
  /// <summary>
  /// Show Default Subtotal
  /// </summary>
  public System.Boolean? DefaultSubtotal { get ; set; }
  
  /// <summary>
  /// Sum Subtotal
  /// </summary>
  public System.Boolean? SumSubtotal { get ; set; }
  
  /// <summary>
  /// CountA
  /// </summary>
  public System.Boolean? CountASubtotal { get ; set; }
  
  /// <summary>
  /// Average
  /// </summary>
  public System.Boolean? AverageSubTotal { get ; set; }
  
  /// <summary>
  /// Max Subtotal
  /// </summary>
  public System.Boolean? MaxSubtotal { get ; set; }
  
  /// <summary>
  /// Min Subtotal
  /// </summary>
  public System.Boolean? MinSubtotal { get ; set; }
  
  /// <summary>
  /// Product Subtotal
  /// </summary>
  public System.Boolean? ApplyProductInSubtotal { get ; set; }
  
  /// <summary>
  /// Count
  /// </summary>
  public System.Boolean? CountSubtotal { get ; set; }
  
  /// <summary>
  /// StdDev Subtotal
  /// </summary>
  public System.Boolean? ApplyStandardDeviationInSubtotal { get ; set; }
  
  /// <summary>
  /// StdDevP Subtotal
  /// </summary>
  public System.Boolean? ApplyStandardDeviationPInSubtotal { get ; set; }
  
  /// <summary>
  /// Variance Subtotal
  /// </summary>
  public System.Boolean? ApplyVarianceInSubtotal { get ; set; }
  
  /// <summary>
  /// VarP Subtotal
  /// </summary>
  public System.Boolean? ApplyVariancePInSubtotal { get ; set; }
  
  /// <summary>
  /// Show Member Property in Cell
  /// </summary>
  public System.Boolean? ShowPropCell { get ; set; }
  
  /// <summary>
  /// Show Member Property ToolTip
  /// </summary>
  public System.Boolean? ShowPropertyTooltip { get ; set; }
  
  /// <summary>
  /// Show As Caption
  /// </summary>
  public System.Boolean? ShowPropAsCaption { get ; set; }
  
  /// <summary>
  /// Drill State
  /// </summary>
  public System.Boolean? DefaultAttributeDrillState { get ; set; }
  
  /// <summary>
  /// Field Items.
  /// </summary>
  public DocumentModel.Spreadsheet.IItems? Items { get ; set; }
  
  /// <summary>
  /// AutoSort Scope.
  /// </summary>
  public DocumentModel.Spreadsheet.IAutoSortScope? AutoSortScope { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotFieldExtensionList? PivotFieldExtensionList { get ; set; }
  
}
