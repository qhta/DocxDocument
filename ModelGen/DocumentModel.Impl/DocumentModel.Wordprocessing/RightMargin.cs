namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Cell Right Margin Exception.
/// </summary>
public class RightMargin: IRightMargin
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
