namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotTableDefinition Class.
/// </summary>
public interface IPivotTableDefinition // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// fillDownLabelsDefault, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? FillDownLabelsDefault { get ; set; }
  
  /// <summary>
  /// visualTotalsForSets, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? VisualTotalsForSets { get ; set; }
  
  /// <summary>
  /// calculatedMembersInFilters, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? CalculatedMembersInFilters { get ; set; }
  
  /// <summary>
  /// altText, this property is only available in Office 2010 and later.
  /// </summary>
  public String? AltText { get ; set; }
  
  /// <summary>
  /// altTextSummary, this property is only available in Office 2010 and later.
  /// </summary>
  public String? AltTextSummary { get ; set; }
  
  /// <summary>
  /// enableEdit, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? EnableEdit { get ; set; }
  
  /// <summary>
  /// autoApply, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? AutoApply { get ; set; }
  
  /// <summary>
  /// allocationMethod, this property is only available in Office 2010 and later.
  /// </summary>
  public AllocationMethodKind? AllocationMethod { get ; set; }
  
  /// <summary>
  /// weightExpression, this property is only available in Office 2010 and later.
  /// </summary>
  public String? WeightExpression { get ; set; }
  
  /// <summary>
  /// hideValuesRow, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? HideValuesRow { get ; set; }
  
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
  public IConditionalFormats? ConditionalFormats { get ; set; }
  
}
