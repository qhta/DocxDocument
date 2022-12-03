namespace DocumentModel.Presentation;

/// <summary>
/// Time Node Preset Class Type
/// </summary>
public enum TimeNodePresetClassKind
{
  /// <summary>
  /// Preset Type Enum ( Entrance ).
  /// </summary>
  [XmlEnum("entr")]
  Entrance,
  
  /// <summary>
  /// Exit.
  /// </summary>
  [XmlEnum("exit")]
  Exit,
  
  /// <summary>
  /// Preset Type Enum ( Emphasis ).
  /// </summary>
  [XmlEnum("emph")]
  Emphasis,
  
  /// <summary>
  /// Preset Type Enum ( Path ).
  /// </summary>
  [XmlEnum("path")]
  Path,
  
  /// <summary>
  /// Preset Type Enum ( Verb ).
  /// </summary>
  [XmlEnum("verb")]
  Verb,
  
  /// <summary>
  /// Preset Type Enum ( Media Call ).
  /// </summary>
  [XmlEnum("mediacall")]
  MediaCall,
  
}
