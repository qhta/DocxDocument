namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the AllocationMethodValues enumeration.
/// </summary>
public enum AllocationMethodValues
{
  /// <summary>
  /// equalAllocation.
  /// </summary>
  [XmlEnum("equalAllocation")]
  EqualAllocation,
  
  /// <summary>
  /// equalIncrement.
  /// </summary>
  [XmlEnum("equalIncrement")]
  EqualIncrement,
  
  /// <summary>
  /// weightedAllocation.
  /// </summary>
  [XmlEnum("weightedAllocation")]
  WeightedAllocation,
  
  /// <summary>
  /// weightedIncrement.
  /// </summary>
  [XmlEnum("weightedIncrement")]
  WeightedIncrement,
  
}
