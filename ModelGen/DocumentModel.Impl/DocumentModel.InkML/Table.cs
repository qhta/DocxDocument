namespace DocumentModel.InkML;

/// <summary>
/// Defines the Table Class.
/// </summary>
public class Table: ITable
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// apply
  /// </summary>
  public TableApplyValues? Apply
  {
    get;
    set;
  }
  
  /// <summary>
  /// interpolation
  /// </summary>
  public TableInterpolationValues? Interpolation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text
  {
    get;
    set;
  }
  
}
