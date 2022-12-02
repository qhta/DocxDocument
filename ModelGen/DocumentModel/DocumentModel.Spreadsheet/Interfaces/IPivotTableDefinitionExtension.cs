namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotTableDefinitionExtension Class.
/// </summary>
public interface IPivotTableDefinitionExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IPivotTableDefinition? PivotTableDefinition { get ; set; }
  
  public IPivotTableData? PivotTableData { get ; set; }
  
  public IPivotTableUISettings? PivotTableUISettings { get ; set; }
  
  public IPivotVersionInfo? PivotVersionInfo { get ; set; }
  
}
