namespace DocumentModel.Spreadsheet;

/// <summary>
/// Entries.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IErrorItem))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMissingItem))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.INumberItem))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IStringItem))]
public class Entries: IEntries
{
  /// <summary>
  /// Tuple Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
