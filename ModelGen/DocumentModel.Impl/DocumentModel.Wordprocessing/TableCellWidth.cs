namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableCellWidth Class.
/// </summary>
public class TableCellWidth: ITableCellWidth
{
  /// <summary>
  /// Table Width Value
  /// </summary>
  public string? Width
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Width Type
  /// </summary>
  public TableWidthUnitValues? Type
  {
    get;
    set;
  }
  
}
