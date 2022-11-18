namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLE Link Items.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IOleItem))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IOleItem))]
public interface IOleItems // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
}
