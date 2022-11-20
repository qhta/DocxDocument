namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the IgnoredErrors Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IIgnoredError))]
public class IgnoredErrors: IIgnoredErrors
{
}
