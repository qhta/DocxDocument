namespace DocumentModel.Spreadsheet;

/// <summary>
/// Custom Filter Criteria.
/// </summary>
public interface ICustomFilter // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Filter Comparison Operator
  /// </summary>
  public FilterOperatorKind? Operator { get ; set; }
  
  /// <summary>
  /// Top or Bottom Value
  /// </summary>
  public String? Val { get ; set; }
  
}
