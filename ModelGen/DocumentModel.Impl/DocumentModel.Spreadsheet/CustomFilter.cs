namespace DocumentModel.Spreadsheet;

/// <summary>
/// Custom Filter Criteria.
/// </summary>
public class CustomFilter: ICustomFilter
{
  /// <summary>
  /// Filter Comparison Operator
  /// </summary>
  public FilterOperatorValues? Operator
  {
    get;
    set;
  }
  
  /// <summary>
  /// Top or Bottom Value
  /// </summary>
  public string? Val
  {
    get;
    set;
  }
  
}
