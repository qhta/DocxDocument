namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Column Definition.
/// </summary>
public class Column: IColumn
{
  /// <summary>
  /// Column Width
  /// </summary>
  public string? Width
  {
    get;
    set;
  }
  
  /// <summary>
  /// Space Before Following Column
  /// </summary>
  public string? Space
  {
    get;
    set;
  }
  
}
