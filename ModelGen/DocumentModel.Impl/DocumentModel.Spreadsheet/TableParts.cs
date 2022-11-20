namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TableParts Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITablePart))]
public class TableParts: ITableParts
{
  /// <summary>
  /// Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
