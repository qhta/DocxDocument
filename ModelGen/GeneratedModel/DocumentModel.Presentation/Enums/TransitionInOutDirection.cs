namespace DocumentModel.Presentation;

/// <summary>
/// Transition In/Out Direction Type
/// </summary>
public enum TransitionInOutDirection
{
  /// <summary>
  /// Transition In/Out Direction Enum ( Out ).
  /// </summary>
  [XmlEnum("out")]
  Out,
  
  /// <summary>
  /// Transition In/Out Direction Enum ( In ).
  /// </summary>
  [XmlEnum("in")]
  In,
  
}
