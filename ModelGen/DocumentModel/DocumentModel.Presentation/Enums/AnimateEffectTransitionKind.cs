namespace DocumentModel.Presentation;

/// <summary>
/// Time List Animate Effect Transition
/// </summary>
public enum AnimateEffectTransitionKind
{
  /// <summary>
  /// Transition Enum ( In ).
  /// </summary>
  [XmlEnum("in")]
  In,
  
  /// <summary>
  /// Transition Enum ( Out ).
  /// </summary>
  [XmlEnum("out")]
  Out,
  
  /// <summary>
  /// Transition Enum ( None ).
  /// </summary>
  [XmlEnum("none")]
  None,
  
}
