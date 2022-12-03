namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FontPitchValues enumeration.
/// </summary>
public enum FontPitchKind
{
  /// <summary>
  /// Fixed Width.
  /// </summary>
  [XmlEnum("fixed")]
  Fixed,
  
  /// <summary>
  /// Proportional Width.
  /// </summary>
  [XmlEnum("variable")]
  Variable,
  
  /// <summary>
  /// Default.
  /// </summary>
  [XmlEnum("default")]
  Default,
  
}
