namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextEffectValues enumeration.
/// </summary>
public enum TextEffectKind
{
  /// <summary>
  /// Blinking Background Animation.
  /// </summary>
  [XmlEnum("blinkBackground")]
  BlinkBackground,
  
  /// <summary>
  /// Colored Lights Animation.
  /// </summary>
  [XmlEnum("lights")]
  Lights,
  
  /// <summary>
  /// Black Dashed Line Animation.
  /// </summary>
  [XmlEnum("antsBlack")]
  AntsBlack,
  
  /// <summary>
  /// Marching Red Ants.
  /// </summary>
  [XmlEnum("antsRed")]
  AntsRed,
  
  /// <summary>
  /// Shimmer Animation.
  /// </summary>
  [XmlEnum("shimmer")]
  Shimmer,
  
  /// <summary>
  /// Sparkling Lights Animation.
  /// </summary>
  [XmlEnum("sparkle")]
  Sparkle,
  
  /// <summary>
  /// No Animation.
  /// </summary>
  [XmlEnum("none")]
  None,
  
}
