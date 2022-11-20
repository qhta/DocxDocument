namespace DocumentModel.Vml.Wordprocessing;

/// <summary>
/// Text Wrapping Type
/// </summary>
public enum WrapValues
{
  /// <summary>
  /// Top and bottom wrapping.
  /// </summary>
  [XmlEnum("topAndBottom")]
  TopAndBottom,
  
  /// <summary>
  /// Square wrapping.
  /// </summary>
  [XmlEnum("square")]
  Square,
  
  /// <summary>
  /// No wrapping.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Tight wrapping.
  /// </summary>
  [XmlEnum("tight")]
  Tight,
  
  /// <summary>
  /// Through wrapping.
  /// </summary>
  [XmlEnum("through")]
  Through,
  
}
