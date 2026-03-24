namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the default start-up mode for the Japanese Input Method Editor (IME).
/// </summary>
public enum WdIMEMode
{
  /// <summary>
  /// Does not change the IME mode.
  /// </summary>
  NoControl = 0,
  /// <summary>
  /// Activates the IME.
  /// </summary>
  On = 1,
  /// <summary>
  /// Disables the IME and activates Latin text entry.
  /// </summary>
  Off = 2,
  /// <summary>
  /// Activates the IME in full-width hiragana mode.
  /// </summary>
  Hiragana = 4,
  /// <summary>
  /// Activates the IME in full-width katakana mode.
  /// </summary>
  Katakana = 5,
  /// <summary>
  /// Activates the IME in half-width katakana mode.
  /// </summary>
  KatakanaHalf = 6,
  /// <summary>
  /// Activates the IME in full-width Latin mode.
  /// </summary>
  AlphaFull = 7,
  /// <summary>
  /// Activates the IME in half-width Latin mode.
  /// </summary>
  Alpha = 8,
  /// <summary>
  /// Activates the IME in full-width Hangul mode.
  /// </summary>
  HangulFull = 9,
  /// <summary>
  /// Activates the IME in half-width Hangul mode.
  /// [System.Runtime.InteropServices.Guid("8BE9FF6B-231C-32F4-8F21-FD47474070BA")] public enum WdIMEMode ﾉ Expand
  /// table
  /// </summary>
  Hangul = 10
}
