namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Worksheet Drawing.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IAbsoluteAnchor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IOneCellAnchor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.ITwoCellAnchor))]
public interface IWorksheetDrawing // : DocumentFormat.OpenXml.TypedOpenXmlPartRootElement
{
}
