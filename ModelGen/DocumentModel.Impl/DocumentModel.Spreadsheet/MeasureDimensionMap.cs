namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Measure Group.
/// </summary>
public class MeasureDimensionMap: IMeasureDimensionMap
{
  /// <summary>
  /// Measure Group Id
  /// </summary>
  public uint? MeasureGroup
  {
    get;
    set;
  }
  
  /// <summary>
  /// Dimension Id
  /// </summary>
  public uint? Dimension
  {
    get;
    set;
  }
  
}
