namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotTableDefinitionExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IPivotTableDefinition))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IPivotTableData))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IPivotTableUISettings))]
[ChildElementInfo(typeof(DocumentModel.Office.SpreadSheetML.Y2022.PivotVersionInfo.IPivotVersionInfo))]
public class PivotTableDefinitionExtension: IPivotTableDefinitionExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
