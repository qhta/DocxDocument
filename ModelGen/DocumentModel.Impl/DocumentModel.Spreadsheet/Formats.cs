namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Formats Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFormat))]
public class Formats: IFormats
{
  /// <summary>
  /// Formats Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
