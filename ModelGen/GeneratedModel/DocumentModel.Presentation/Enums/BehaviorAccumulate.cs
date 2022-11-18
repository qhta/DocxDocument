namespace DocumentModel.Presentation;

/// <summary>
/// Behavior Accumulate Type
/// </summary>
public enum BehaviorAccumulate
{
  /// <summary>
  /// Accumulate Enum ( None ).
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Accumulate Enum ( Always ).
  /// </summary>
  [XmlEnum("always")]
  Always,
  
}
