namespace DocumentModel.Spreadsheet;

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
