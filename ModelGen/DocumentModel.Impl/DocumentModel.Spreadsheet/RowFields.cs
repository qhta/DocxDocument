namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the RowFields Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IField))]
public class RowFields: IRowFields
{
  /// <summary>
  /// Repeated Items Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
