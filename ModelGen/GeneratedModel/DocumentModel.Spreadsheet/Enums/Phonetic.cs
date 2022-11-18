namespace DocumentModel.Spreadsheet;

/// <summary>
/// Phonetic Type
/// </summary>
public enum Phonetic
{
  /// <summary>
  /// Half-Width Katakana.
  /// </summary>
  [XmlEnum("halfwidthKatakana")]
  HalfWidthKatakana,
  
  /// <summary>
  /// Full-Width Katakana.
  /// </summary>
  [XmlEnum("fullwidthKatakana")]
  FullWidthKatakana,
  
  /// <summary>
  /// Hiragana.
  /// </summary>
  [XmlEnum("Hiragana")]
  Hiragana,
  
  /// <summary>
  /// No Conversion.
  /// </summary>
  [XmlEnum("noConversion")]
  NoConversion,
  
}
