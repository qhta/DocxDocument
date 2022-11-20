namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DataFields Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDataField))]
public class DataFields: IDataFields
{
  /// <summary>
  /// Data Items Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
