namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the NumberingFormats Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.INumberingFormat))]
public class NumberingFormats: INumberingFormats
{
  /// <summary>
  /// Number Format Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
