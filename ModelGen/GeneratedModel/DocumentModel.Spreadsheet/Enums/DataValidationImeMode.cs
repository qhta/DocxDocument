namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Validation IME Mode
/// </summary>
public enum DataValidationImeMode
{
  /// <summary>
  /// IME Mode Not Controlled.
  /// </summary>
  [XmlEnum("noControl")]
  NoControl,
  
  /// <summary>
  /// IME Off.
  /// </summary>
  [XmlEnum("off")]
  Off,
  
  /// <summary>
  /// IME On.
  /// </summary>
  [XmlEnum("on")]
  On,
  
  /// <summary>
  /// Disabled IME Mode.
  /// </summary>
  [XmlEnum("disabled")]
  Disabled,
  
  /// <summary>
  /// Hiragana IME Mode.
  /// </summary>
  [XmlEnum("hiragana")]
  Hiragana,
  
  /// <summary>
  /// Full Katakana IME Mode.
  /// </summary>
  [XmlEnum("fullKatakana")]
  FullKatakana,
  
  /// <summary>
  /// Half-Width Katakana.
  /// </summary>
  [XmlEnum("halfKatakana")]
  HalfKatakana,
  
  /// <summary>
  /// Full-Width Alpha-Numeric IME Mode.
  /// </summary>
  [XmlEnum("fullAlpha")]
  FullAlpha,
  
  /// <summary>
  /// Half Alpha IME.
  /// </summary>
  [XmlEnum("halfAlpha")]
  HalfAlpha,
  
  /// <summary>
  /// Full Width Hangul.
  /// </summary>
  [XmlEnum("fullHangul")]
  FullHangul,
  
  /// <summary>
  /// Half-Width Hangul IME Mode.
  /// </summary>
  [XmlEnum("halfHangul")]
  HalfHangul,
  
}
