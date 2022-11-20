namespace DocumentModel.Spreadsheet;

/// <summary>
/// Cell Watch Item.
/// </summary>
public class CellWatch: ICellWatch
{
  /// <summary>
  /// Reference
  /// </summary>
  public string? CellReference
  {
    get;
    set;
  }
  
}
