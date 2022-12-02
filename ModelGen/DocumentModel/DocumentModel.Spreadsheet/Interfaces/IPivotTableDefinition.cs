namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotTableDefinition Class.
/// </summary>
public interface IPivotTableDefinition // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// fillDownLabelsDefault, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? FillDownLabelsDefault { get ; set; }
  
  /// <summary>
  /// visualTotalsForSets, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? VisualTotalsForSets { get ; set; }
  
  /// <summary>
  /// calculatedMembersInFilters, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? CalculatedMembersInFilters { get ; set; }
  
  /// <summary>
  /// altText, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? AltText { get ; set; }
  
  /// <summary>
  /// altTextSummary, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? AltTextSummary { get ; set; }
  
  /// <summary>
  /// enableEdit, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? EnableEdit { get ; set; }
  
  /// <summary>
  /// autoApply, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? AutoApply { get ; set; }
  
  /// <summary>
  /// allocationMethod, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.AllocationMethodKind? AllocationMethod { get ; set; }
  
  /// <summary>
  /// weightExpression, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? WeightExpression { get ; set; }
  
  /// <summary>
  /// hideValuesRow, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? HideValuesRow { get ; set; }
  
  /// <summary>
  /// PivotEdits.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotEdits? PivotEdits { get ; set; }
  
  /// <summary>
  /// PivotChanges.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotChanges? PivotChanges { get ; set; }
  
  /// <summary>
  /// ConditionalFormats.
  /// </summary>
  public DocumentModel.Spreadsheet.IConditionalFormats? ConditionalFormats { get ; set; }
  
}
