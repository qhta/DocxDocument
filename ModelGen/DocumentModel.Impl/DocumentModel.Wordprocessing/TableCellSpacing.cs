namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableCellSpacing Class.
/// </summary>
public class TableCellSpacing: ITableCellSpacing
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
