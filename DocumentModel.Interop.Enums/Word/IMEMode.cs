namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the default start-up mode for the Japanese Input Method Editor (IME).
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdimemode?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdIMEMode")]
public enum IMEMode
{
  /// <summary>
  /// Does not change the IME mode.
  /// </summary>
  [WordInteropEnumValue("wdIMEModeNoControl")]
  NoControl = 0,
  /// <summary>
  /// Activates the IME.
  /// </summary>
  [WordInteropEnumValue("wdIMEModeOn")]
  On = 1,
  /// <summary>
  /// Disables the IME and activates Latin text entry.
  /// </summary>
  [WordInteropEnumValue("wdIMEModeOff")]
  Off = 2,
  /// <summary>
  /// Activates the IME in full-width hiragana mode.
  /// </summary>
  [WordInteropEnumValue("wdIMEModeHiragana")]
  Hiragana = 4,
  /// <summary>
  /// Activates the IME in full-width katakana mode.
  /// </summary>
  [WordInteropEnumValue("wdIMEModeKatakana")]
  Katakana = 5,
  /// <summary>
  /// Activates the IME in half-width katakana mode.
  /// </summary>
  [WordInteropEnumValue("wdIMEModeKatakanaHalf")]
  KatakanaHalf = 6,
  /// <summary>
  /// Activates the IME in full-width Latin mode.
  /// </summary>
  [WordInteropEnumValue("wdIMEModeAlphaFull")]
  AlphaFull = 7,
  /// <summary>
  /// Activates the IME in half-width Latin mode.
  /// </summary>
  [WordInteropEnumValue("wdIMEModeAlpha")]
  Alpha = 8,
  /// <summary>
  /// Activates the IME in full-width Hangul mode.
  /// </summary>
  [WordInteropEnumValue("wdIMEModeHangulFull")]
  HangulFull = 9,
  /// <summary>
  /// Activates the IME in half-width Hangul mode.
  /// </summary>
  [WordInteropEnumValue("wdIMEModeHangul")]
  Hangul = 10
}
