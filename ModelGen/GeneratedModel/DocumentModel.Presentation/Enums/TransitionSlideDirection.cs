namespace DocumentModel.Presentation;

/// <summary>
/// Transition Slide Direction Type
/// </summary>
public enum TransitionSlideDirection
{
  /// <summary>
  /// Transition Slide Direction Enum ( Left ).
  /// </summary>
  [XmlEnum("l")]
  Left,
  
  /// <summary>
  /// Transition Slide Direction Enum ( Up ).
  /// </summary>
  [XmlEnum("u")]
  Up,
  
  /// <summary>
  /// Transition Slide Direction ( Right ).
  /// </summary>
  [XmlEnum("r")]
  Right,
  
  /// <summary>
  /// Transition Slide Direction Enum ( Down ).
  /// </summary>
  [XmlEnum("d")]
  Down,
  
}
