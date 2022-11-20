namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Fills Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFill))]
public class Fills: IFills
{
  /// <summary>
  /// Fill Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
