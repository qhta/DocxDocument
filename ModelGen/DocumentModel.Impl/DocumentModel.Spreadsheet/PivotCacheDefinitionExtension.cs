namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotCacheDefinitionExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IPivotCacheDefinition))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IPivotCacheDecoupled))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IPivotCacheIdVersion))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.ITimelinePivotCacheDefinition))]
[ChildElementInfo(typeof(DocumentModel.Office2021.Excel.Pivot.IXsdboolean))]
[ChildElementInfo(typeof(DocumentModel.Office.SpreadSheetML.Y2022.PivotVersionInfo.ICacheVersionInfo))]
public class PivotCacheDefinitionExtension: IPivotCacheDefinitionExtension
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
