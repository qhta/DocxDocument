namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the AllocationMethodValues enumeration.
/// </summary>
public enum AllocationMethodKind
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
