namespace DocumentModel.Math;

/// <summary>
/// Defines the StyleValues enumeration.
/// </summary>
public enum Style
{
  /// <summary>
  /// Plain.
  /// </summary>
  [XmlEnum("p")]
  Plain,
  
  /// <summary>
  /// Bold.
  /// </summary>
  [XmlEnum("b")]
  Bold,
  
  /// <summary>
  /// Italic.
  /// </summary>
  [XmlEnum("i")]
  Italic,
  
  /// <summary>
  /// Bold-Italic.
  /// </summary>
  [XmlEnum("bi")]
  BoldItalic,
  
}
