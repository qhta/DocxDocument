namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of the selected Japanese text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdkana?view=office-pia` for Office interop details.
/// </remarks>
public enum WdKana
{
  /// <summary>
  /// The text is formatted as Katakana.
  /// </summary>
  Katakana = 8,
  /// <summary>
  /// The text is formatted as Hiragana.
  /// </summary>
  Hiragana = 9
}
