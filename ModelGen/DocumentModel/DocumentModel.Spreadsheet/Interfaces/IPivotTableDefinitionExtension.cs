namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotTableDefinitionExtension Class.
/// </summary>
public interface IPivotTableDefinitionExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Spreadsheet.IPivotTableDefinition? PivotTableDefinition { get ; set; }
  
  public DocumentModel.Spreadsheet.IPivotTableData? PivotTableData { get ; set; }
  
  public DocumentModel.Spreadsheet.IPivotTableUISettings? PivotTableUISettings { get ; set; }
  
  public DocumentModel.Spreadsheet.IPivotVersionInfo? PivotVersionInfo { get ; set; }
  
}
