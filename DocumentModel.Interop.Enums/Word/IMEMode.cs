namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the default start-up mode for the Japanese Input Method Editor (IME).
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdimemode?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdIMEMode))]
public enum IMEMode
{
  /// <summary>
  /// Does not change the IME mode.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIMEMode.wdIMEModeNoControl))]
  NoControl = 0,
  /// <summary>
  /// Activates the IME.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIMEMode.wdIMEModeOn))]
  On = 1,
  /// <summary>
  /// Disables the IME and activates Latin text entry.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIMEMode.wdIMEModeOff))]
  Off = 2,
  /// <summary>
  /// Activates the IME in full-width hiragana mode.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIMEMode.wdIMEModeHiragana))]
  Hiragana = 4,
  /// <summary>
  /// Activates the IME in full-width katakana mode.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIMEMode.wdIMEModeKatakana))]
  Katakana = 5,
  /// <summary>
  /// Activates the IME in half-width katakana mode.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIMEMode.wdIMEModeKatakanaHalf))]
  KatakanaHalf = 6,
  /// <summary>
  /// Activates the IME in full-width Latin mode.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIMEMode.wdIMEModeAlphaFull))]
  AlphaFull = 7,
  /// <summary>
  /// Activates the IME in half-width Latin mode.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIMEMode.wdIMEModeAlpha))]
  Alpha = 8,
  /// <summary>
  /// Activates the IME in full-width Hangul mode.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIMEMode.wdIMEModeHangulFull))]
  HangulFull = 9,
  /// <summary>
  /// Activates the IME in half-width Hangul mode.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIMEMode.wdIMEModeHangul))]
  Hangul = 10
}
