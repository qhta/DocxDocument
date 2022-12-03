namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotTableDefinitionExtension Class.
/// </summary>
public interface PivotTableDefinitionExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public PivotTableDefinition? PivotTableDefinition { get ; set; }
  
  public PivotTableData? PivotTableData { get ; set; }
  
  public PivotTableUISettings? PivotTableUISettings { get ; set; }
  
  public PivotVersionInfo? PivotVersionInfo { get ; set; }
  
}
