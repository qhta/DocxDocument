namespace DocumentModel.Spreadsheet;

/// <summary>
/// Dialog Sheet Views.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ISheetView))]
public class SheetViews: ISheetViews
{
}
