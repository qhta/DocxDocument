namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a spelling error type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdspellingerrortype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdSpellingErrorType))]
public enum SpellingErrorType
{
  /// <summary>
  /// Spelling is correct.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpellingErrorType.wdSpellingCorrect))]
  Correct = 0,
  /// <summary>
  /// The word is not in the specified dictionary.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpellingErrorType.wdSpellingNotInDictionary))]
  NotInDictionary = 1,
  /// <summary>
  /// Capitalization error.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpellingErrorType.wdSpellingCapitalization))]
  Capitalization = 2
}
