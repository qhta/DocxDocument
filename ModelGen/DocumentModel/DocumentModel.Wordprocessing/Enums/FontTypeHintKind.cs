namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FontTypeHintValues enumeration.
/// </summary>
public enum FontTypeHintKind
{
  /// <summary>
  /// High ANSI Font.
  /// </summary>
  [XmlEnum("default")]
  Default,
  
  /// <summary>
  /// East Asian Font.
  /// </summary>
  [XmlEnum("eastAsia")]
  EastAsia,
  
  /// <summary>
  /// Complex Script Font.
  /// </summary>
  [XmlEnum("cs")]
  ComplexScript,
  
}
