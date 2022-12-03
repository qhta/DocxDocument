namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Measure Group.
/// </summary>
public interface MeasureGroup // : System.Boolean
{
  /// <summary>
  /// Measure Group Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Measure Group Display Name
  /// </summary>
  public String? Caption { get ; set; }
  
}
