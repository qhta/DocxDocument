namespace DocumentModel.Math;

/// <summary>
/// Defines the BreakBinaryOperatorValues enumeration.
/// </summary>
public enum BreakBinaryOperator
{
  /// <summary>
  /// Before.
  /// </summary>
  [XmlEnum("before")]
  Before,
  
  /// <summary>
  /// After.
  /// </summary>
  [XmlEnum("after")]
  After,
  
  /// <summary>
  /// Repeat.
  /// </summary>
  [XmlEnum("repeat")]
  Repeat,
  
}
