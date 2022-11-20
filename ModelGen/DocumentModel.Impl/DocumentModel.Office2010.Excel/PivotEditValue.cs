namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the PivotEditValue Class.
/// </summary>
public class PivotEditValue: IPivotEditValue
{
  /// <summary>
  /// valueType, this property is only available in Office 2010 and later.
  /// </summary>
  public PivotEditValueTypeValues? ValueType
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
