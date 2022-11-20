namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the EndMargin Class.
/// </summary>
public class EndMargin: IEndMargin
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
