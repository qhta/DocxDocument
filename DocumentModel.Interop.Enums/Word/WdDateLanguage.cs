namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the language format to apply to the current date, time, or both.
/// </summary>
public enum WdDateLanguage
{
  /// <summary>
  /// Bidirectional date/time format.
  /// </summary>
  wdDateLanguageBidi = unchecked((int)10),
  /// <summary>
  /// Latin date/time format.
  /// </summary>
  wdDateLanguageLatin = unchecked((int)1033)
}
