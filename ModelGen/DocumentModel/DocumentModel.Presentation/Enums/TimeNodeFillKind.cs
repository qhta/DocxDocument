namespace DocumentModel.Presentation;

/// <summary>
/// Time Node Fill Type
/// </summary>
public enum TimeNodeFillKind
{
  /// <summary>
  /// Remove.
  /// </summary>
  [XmlEnum("remove")]
  Remove,
  
  /// <summary>
  /// Freeze.
  /// </summary>
  [XmlEnum("freeze")]
  Freeze,
  
  /// <summary>
  /// TimeNode Fill Type Enum ( Hold ).
  /// </summary>
  [XmlEnum("hold")]
  Hold,
  
  /// <summary>
  /// Transition.
  /// </summary>
  [XmlEnum("transition")]
  Transition,
  
}
