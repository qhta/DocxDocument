namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the WidthAfterTableRow Class.
/// </summary>
public class WidthAfterTableRow: IWidthAfterTableRow
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
