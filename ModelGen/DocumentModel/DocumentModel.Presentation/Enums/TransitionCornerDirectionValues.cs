namespace DocumentModel.Presentation;

/// <summary>
/// Transition Corner Direction Type
/// </summary>
public enum TransitionCornerDirectionValues
{
  /// <summary>
  /// Transition Corner Direction Enum ( Left-Up ).
  /// </summary>
  [XmlEnum("lu")]
  LeftUp,
  
  /// <summary>
  /// Transition Corner Direction Enum ( Right-Up ).
  /// </summary>
  [XmlEnum("ru")]
  RightUp,
  
  /// <summary>
  /// Transition Corner Direction Enum ( Left-Down ).
  /// </summary>
  [XmlEnum("ld")]
  LeftDown,
  
  /// <summary>
  /// Transition Corner Direction Enum ( Right-Down ).
  /// </summary>
  [XmlEnum("rd")]
  RightDown,
  
}
