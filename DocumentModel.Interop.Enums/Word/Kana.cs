namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of the selected Japanese text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdkana?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdKana")]
public enum Kana
{
  /// <summary>
  /// The text is formatted as Katakana.
  /// </summary>
  [WordInteropEnumValue("wdKanaKatakana")]
  Katakana = 8,
  /// <summary>
  /// The text is formatted as Hiragana.
  /// </summary>
  [WordInteropEnumValue("wdKanaHiragana")]
  Hiragana = 9
}
