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
  
  public DocumentModel.Office2010.Excel.IPivotTableDefinition? PivotTableDefinition { get ; set; }
  
  public DocumentModel.Office2013.Excel.IPivotTableData? PivotTableData { get ; set; }
  
  public DocumentModel.Office2013.Excel.IPivotTableUISettings? PivotTableUISettings { get ; set; }
  
  public DocumentModel.Office.SpreadSheetML.Y2022.PivotVersionInfo.IPivotVersionInfo? PivotVersionInfo { get ; set; }
  
}
