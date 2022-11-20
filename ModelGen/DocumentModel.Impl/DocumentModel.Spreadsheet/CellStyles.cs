namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CellStyles Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICellStyle))]
public class CellStyles: ICellStyles
{
  /// <summary>
  /// Style Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
