namespace DocumentModel.Spreadsheet;

/// <summary>
/// Row.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExternalCell))]
public class ExternalRow: IExternalRow
{
  /// <summary>
  /// Row
  /// </summary>
  public uint? RowIndex
  {
    get;
    set;
  }
  
}
