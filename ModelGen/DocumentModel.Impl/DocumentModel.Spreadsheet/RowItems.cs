namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the RowItems Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRowItem))]
public class RowItems: IRowItems
{
  /// <summary>
  /// Items in a Row Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
