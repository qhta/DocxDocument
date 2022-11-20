namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableIndentation Class.
/// </summary>
public class TableIndentation: ITableIndentation
{
  /// <summary>
  /// w
  /// </summary>
  public int? Width
  {
    get;
    set;
  }
  
  /// <summary>
  /// type
  /// </summary>
  public TableWidthUnitValues? Type
  {
    get;
    set;
  }
  
}
