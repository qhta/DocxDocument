namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a spelling error type.
/// </summary>
public enum WdSpellingErrorType
{
  /// <summary>
  /// Spelling is correct.
  /// </summary>
  wdSpellingCorrect = unchecked((int)0),
  /// <summary>
  /// The word is not in the specified dictionary.
  /// </summary>
  wdSpellingNotInDictionary = unchecked((int)1),
  /// <summary>
  /// Capitalization error.
  /// </summary>
  wdSpellingCapitalization = unchecked((int)2)
}
