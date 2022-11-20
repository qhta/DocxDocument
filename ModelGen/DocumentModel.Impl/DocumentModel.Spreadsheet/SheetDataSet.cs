namespace DocumentModel.Spreadsheet;

/// <summary>
/// Cached worksheet data associated with supporting book.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExternalSheetData))]
public class SheetDataSet: ISheetDataSet
{
}
