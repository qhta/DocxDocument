namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the WorksheetExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IConditionalFormattings))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IDataValidations))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IIgnoredErrors))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IProtectedRanges))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ISlicerList))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ISparklineGroups))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.ITimelineReferences))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IWebExtensions))]
public interface IWorksheetExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
