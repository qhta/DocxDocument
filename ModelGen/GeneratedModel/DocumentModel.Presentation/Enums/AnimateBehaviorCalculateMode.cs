namespace DocumentModel.Presentation;

/// <summary>
/// Time List Animate Behavior Calculate Mode
/// </summary>
public enum AnimateBehaviorCalculateMode
{
  /// <summary>
  /// Calc Mode Enum ( Discrete ).
  /// </summary>
  [XmlEnum("discrete")]
  Discrete,
  
  /// <summary>
  /// Calc Mode Enum ( Linear ).
  /// </summary>
  [XmlEnum("lin")]
  Linear,
  
  /// <summary>
  /// Calc Mode Enum ( Formula ).
  /// </summary>
  [XmlEnum("fmla")]
  Formula,
  
}
