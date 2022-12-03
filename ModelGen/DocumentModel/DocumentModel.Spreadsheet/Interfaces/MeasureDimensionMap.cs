namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Measure Group.
/// </summary>
public interface MeasureDimensionMap // : System.Boolean
{
  /// <summary>
  /// Measure Group Id
  /// </summary>
  public UInt32? MeasureGroup { get ; set; }
  
  /// <summary>
  /// Dimension Id
  /// </summary>
  public UInt32? Dimension { get ; set; }
  
}
