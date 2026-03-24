namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a spelling error type.
/// </summary>
public enum WdSpellingErrorType
{
  /// <summary>
  /// Spelling is correct.
  /// </summary>
  Correct = unchecked((int)0),
  /// <summary>
  /// The word is not in the specified dictionary.
  /// </summary>
  NotInDictionary = unchecked((int)1),
  /// <summary>
  /// Capitalization error.
  /// </summary>
  Capitalization = unchecked((int)2)
}
