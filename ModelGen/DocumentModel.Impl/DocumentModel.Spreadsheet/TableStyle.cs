namespace DocumentModel.Spreadsheet;

/// <summary>
/// Table Style.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITableStyleElement))]
public class TableStyle: ITableStyle
{
  /// <summary>
  /// Table Style Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Pivot Style
  /// </summary>
  public bool? Pivot
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table
  /// </summary>
  public bool? Table
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Style Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
