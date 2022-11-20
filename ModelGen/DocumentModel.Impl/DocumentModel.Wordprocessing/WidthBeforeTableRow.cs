namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the WidthBeforeTableRow Class.
/// </summary>
public class WidthBeforeTableRow: IWidthBeforeTableRow
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
