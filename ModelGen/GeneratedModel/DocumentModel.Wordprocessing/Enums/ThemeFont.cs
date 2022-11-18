namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ThemeFontValues enumeration.
/// </summary>
public enum ThemeFont
{
  /// <summary>
  /// Major East Asian Theme Font.
  /// </summary>
  [XmlEnum("majorEastAsia")]
  MajorEastAsia,
  
  /// <summary>
  /// Major Complex Script Theme Font.
  /// </summary>
  [XmlEnum("majorBidi")]
  MajorBidi,
  
  /// <summary>
  /// Major ASCII Theme Font.
  /// </summary>
  [XmlEnum("majorAscii")]
  MajorAscii,
  
  /// <summary>
  /// Major High ANSI Theme Font.
  /// </summary>
  [XmlEnum("majorHAnsi")]
  MajorHighAnsi,
  
  /// <summary>
  /// Minor East Asian Theme Font.
  /// </summary>
  [XmlEnum("minorEastAsia")]
  MinorEastAsia,
  
  /// <summary>
  /// Minor Complex Script Theme Font.
  /// </summary>
  [XmlEnum("minorBidi")]
  MinorBidi,
  
  /// <summary>
  /// Minor ASCII Theme Font.
  /// </summary>
  [XmlEnum("minorAscii")]
  MinorAscii,
  
  /// <summary>
  /// Minor High ANSI Theme Font.
  /// </summary>
  [XmlEnum("minorHAnsi")]
  MinorHighAnsi,
  
}
