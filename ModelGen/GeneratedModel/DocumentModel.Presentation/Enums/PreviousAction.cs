namespace DocumentModel.Presentation;

/// <summary>
/// Previous Action Type
/// </summary>
public enum PreviousAction
{
  /// <summary>
  /// Previous Action Type Enum ( None ).
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Previous Action Type Enum ( Skip Timed ).
  /// </summary>
  [XmlEnum("skipTimed")]
  SkipTimed,
  
}
