namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a spelling error type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdspellingerrortype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdSpellingErrorType")]
public enum SpellingErrorType
{
  /// <summary>
  /// Spelling is correct.
  /// </summary>
  [InteropEnumValue("wdSpellingCorrect")]
  Correct = 0,
  /// <summary>
  /// The word is not in the specified dictionary.
  /// </summary>
  [InteropEnumValue("wdSpellingNotInDictionary")]
  NotInDictionary = 1,
  /// <summary>
  /// Capitalization error.
  /// </summary>
  [InteropEnumValue("wdSpellingCapitalization")]
  Capitalization = 2
}
