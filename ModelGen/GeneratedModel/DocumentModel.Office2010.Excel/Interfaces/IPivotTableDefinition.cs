namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the PivotTableDefinition Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IConditionalFormats))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IPivotChanges))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IPivotEdits))]
public interface IPivotTableDefinition // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// fillDownLabelsDefault, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? FillDownLabelsDefault { get ; set; }
  
  /// <summary>
  /// visualTotalsForSets, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? VisualTotalsForSets { get ; set; }
  
  /// <summary>
  /// calculatedMembersInFilters, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? CalculatedMembersInFilters { get ; set; }
  
  /// <summary>
  /// altText, this property is only available in Office 2010 and later.
  /// </summary>
  public string? AltText { get ; set; }
  
  /// <summary>
  /// altTextSummary, this property is only available in Office 2010 and later.
  /// </summary>
  public string? AltTextSummary { get ; set; }
  
  /// <summary>
  /// enableEdit, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? EnableEdit { get ; set; }
  
  /// <summary>
  /// autoApply, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? AutoApply { get ; set; }
  
  /// <summary>
  /// allocationMethod, this property is only available in Office 2010 and later.
  /// </summary>
  public AllocationMethod? AllocationMethod { get ; set; }
  
  /// <summary>
  /// weightExpression, this property is only available in Office 2010 and later.
  /// </summary>
  public string? WeightExpression { get ; set; }
  
  /// <summary>
  /// hideValuesRow, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? HideValuesRow { get ; set; }
  
  /// <summary>
  /// PivotEdits.
  /// </summary>
  public IPivotEdits? PivotEdits { get ; set; }
  
  /// <summary>
  /// PivotChanges.
  /// </summary>
  public IPivotChanges? PivotChanges { get ; set; }
  
  /// <summary>
  /// ConditionalFormats.
  /// </summary>
  public DocumentModel.Office2010.Excel.IConditionalFormats? ConditionalFormats { get ; set; }
  
}
