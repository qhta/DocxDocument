namespace DocumentModel.Presentation;

/// <summary>
/// Transition Speed
/// </summary>
public enum TransitionSpeedValues
{
  /// <summary>
  /// low.
  /// </summary>
  [XmlEnum("slow")]
  Slow,
  
  /// <summary>
  /// Medium.
  /// </summary>
  [XmlEnum("med")]
  Medium,
  
  /// <summary>
  /// Fast.
  /// </summary>
  [XmlEnum("fast")]
  Fast,
  
}
