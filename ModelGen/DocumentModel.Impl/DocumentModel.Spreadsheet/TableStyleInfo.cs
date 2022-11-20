namespace DocumentModel.Spreadsheet;

/// <summary>
/// Table Style.
/// </summary>
public class TableStyleInfo: ITableStyleInfo
{
  /// <summary>
  /// Style Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show First Column
  /// </summary>
  public bool? ShowFirstColumn
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show Last Column
  /// </summary>
  public bool? ShowLastColumn
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show Row Stripes
  /// </summary>
  public bool? ShowRowStripes
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show Column Stripes
  /// </summary>
  public bool? ShowColumnStripes
  {
    get;
    set;
  }
  
}
