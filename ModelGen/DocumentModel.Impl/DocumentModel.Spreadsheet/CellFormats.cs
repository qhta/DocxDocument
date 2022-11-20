namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CellFormats Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICellFormat))]
public class CellFormats: ICellFormats
{
  /// <summary>
  /// Format Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
