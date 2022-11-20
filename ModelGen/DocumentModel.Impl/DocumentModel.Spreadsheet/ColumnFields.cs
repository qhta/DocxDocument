namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ColumnFields Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IField))]
public class ColumnFields: IColumnFields
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
