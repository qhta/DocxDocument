namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FontFamilyValues enumeration.
/// </summary>
public enum FontFamilyValues
{
  /// <summary>
  /// Novelty Font.
  /// </summary>
  [XmlEnum("decorative")]
  Decorative,
  
  /// <summary>
  /// Monospace Font.
  /// </summary>
  [XmlEnum("modern")]
  Modern,
  
  /// <summary>
  /// Proportional Font With Serifs.
  /// </summary>
  [XmlEnum("roman")]
  Roman,
  
  /// <summary>
  /// Script Font.
  /// </summary>
  [XmlEnum("script")]
  Script,
  
  /// <summary>
  /// Proportional Font Without Serifs.
  /// </summary>
  [XmlEnum("swiss")]
  Swiss,
  
  /// <summary>
  /// No Font Family.
  /// </summary>
  [XmlEnum("auto")]
  Auto,
  
}
