namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CellStyleFormats Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICellFormat))]
public class CellStyleFormats: ICellStyleFormats
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
