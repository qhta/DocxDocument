namespace DocumentModel.Spreadsheet;

/// <summary>
/// Tables.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFieldItem))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMissingTable))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICharacterValue))]
public class Tables: ITables
{
  /// <summary>
  /// Count of Tables
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
