namespace DocumentModel.Spreadsheet;

/// <summary>
/// Custom Filter Criteria.
/// </summary>
public interface ICustomFilter // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Filter Comparison Operator
  /// </summary>
  public FilterOperator? Operator { get ; set; }
  
  /// <summary>
  /// Top or Bottom Value
  /// </summary>
  public string? Val { get ; set; }
  
}
