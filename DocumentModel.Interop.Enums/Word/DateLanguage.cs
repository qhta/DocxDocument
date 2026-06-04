namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the language format to apply to the current date, time, or both.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddatelanguage?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdDateLanguage))]
public enum DateLanguage
{
  /// <summary>
  /// Bidirectional date/time format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDateLanguage.wdDateLanguageBidi))]
  Bidi = 10,
  /// <summary>
  /// Latin date/time format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDateLanguage.wdDateLanguageLatin))]
  Latin = 1033
}
