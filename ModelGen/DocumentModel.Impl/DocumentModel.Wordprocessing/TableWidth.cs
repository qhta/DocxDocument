namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableWidth Class.
/// </summary>
public class TableWidth: ITableWidth
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
