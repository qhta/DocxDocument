namespace DocumentModel.Presentation;

/// <summary>
/// Time Node Restart Type
/// </summary>
public enum TimeNodeRestartValues
{
  /// <summary>
  /// Restart Enum ( Always ).
  /// </summary>
  [XmlEnum("always")]
  Always,
  
  /// <summary>
  /// Restart Enum ( When Not Active ).
  /// </summary>
  [XmlEnum("whenNotActive")]
  WhenNotActive,
  
  /// <summary>
  /// Restart Enum ( Never ).
  /// </summary>
  [XmlEnum("never")]
  Never,
  
}
