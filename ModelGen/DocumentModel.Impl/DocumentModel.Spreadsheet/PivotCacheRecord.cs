namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotCache Record.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IBooleanItem))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDateTimeItem))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IErrorItem))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFieldItem))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMissingItem))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.INumberItem))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IStringItem))]
public class PivotCacheRecord: IPivotCacheRecord
{
}
