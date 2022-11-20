namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the DifferentialFormats Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDifferentialFormat))]
public class DifferentialFormats: IDifferentialFormats
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
