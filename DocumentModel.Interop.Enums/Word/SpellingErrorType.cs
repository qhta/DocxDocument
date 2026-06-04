namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a spelling error type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdspellingerrortype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdSpellingErrorType")]
public enum SpellingErrorType
{
  /// <summary>
  /// Spelling is correct.
  /// </summary>
  [WordInteropEnumValue("wdSpellingCorrect")]
  Correct = 0,
  /// <summary>
  /// The word is not in the specified dictionary.
  /// </summary>
  [WordInteropEnumValue("wdSpellingNotInDictionary")]
  NotInDictionary = 1,
  /// <summary>
  /// Capitalization error.
  /// </summary>
  [WordInteropEnumValue("wdSpellingCapitalization")]
  Capitalization = 2
}
