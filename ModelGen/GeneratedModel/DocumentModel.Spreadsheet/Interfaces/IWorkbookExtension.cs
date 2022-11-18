namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the WorkbookExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IPivotCaches))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IPivotCaches))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.ITimelineCachePivotCaches))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IDefinedNames))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ISlicerCaches))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.ISlicerCaches))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IWorkbookProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IDataModel))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IPivotTableReferences))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.ITimelineCacheReferences))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IWorkbookProperties))]
public interface IWorkbookExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
