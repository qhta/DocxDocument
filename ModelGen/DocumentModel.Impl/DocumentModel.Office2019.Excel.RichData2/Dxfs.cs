namespace DocumentModel.Office2019.Excel.RichData2;

/// <summary>
/// Defines the Dxfs Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDifferentialFormat))]
public class Dxfs: IDxfs
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
