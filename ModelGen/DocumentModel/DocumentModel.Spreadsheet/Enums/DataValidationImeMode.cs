namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Validation IME Mode
/// </summary>
public enum DataValidationImeMode
{
  /// <summary>
  /// IME Mode Not Controlled.
  /// </summary>
  NoControl,
  
  /// <summary>
  /// IME Off.
  /// </summary>
  Off,
  
  /// <summary>
  /// IME On.
  /// </summary>
  On,
  
  /// <summary>
  /// Disabled IME Mode.
  /// </summary>
  Disabled,
  
  /// <summary>
  /// Hiragana IME Mode.
  /// </summary>
  Hiragana,
  
  /// <summary>
  /// Full Katakana IME Mode.
  /// </summary>
  FullKatakana,
  
  /// <summary>
  /// Half-Width Katakana.
  /// </summary>
  HalfKatakana,
  
  /// <summary>
  /// Full-Width Alpha-Numeric IME Mode.
  /// </summary>
  FullAlpha,
  
  /// <summary>
  /// Half Alpha IME.
  /// </summary>
  HalfAlpha,
  
  /// <summary>
  /// Full Width Hangul.
  /// </summary>
  FullHangul,
  
  /// <summary>
  /// Half-Width Hangul IME Mode.
  /// </summary>
  HalfHangul,
  
}
