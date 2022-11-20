namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the StartMargin Class.
/// </summary>
public class StartMargin: IStartMargin
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
