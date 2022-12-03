namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotEditValue Class.
/// </summary>
public interface PivotEditValue // : System.String
{
  /// <summary>
  /// valueType, this property is only available in Office 2010 and later.
  /// </summary>
  public PivotEditValueKind? ValueType { get ; set; }
  
}
