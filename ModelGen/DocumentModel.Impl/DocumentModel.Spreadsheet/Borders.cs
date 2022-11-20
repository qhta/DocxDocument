namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Borders Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IBorder))]
public class Borders: IBorders
{
  /// <summary>
  /// Border Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
