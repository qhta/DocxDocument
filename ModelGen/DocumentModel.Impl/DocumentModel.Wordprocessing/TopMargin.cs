namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Cell Top Margin Default.
/// </summary>
public class TopMargin: ITopMargin
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
