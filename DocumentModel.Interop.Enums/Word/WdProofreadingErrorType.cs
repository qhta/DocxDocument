namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of proofreading error returned by the Word proofreading process.
/// </summary>
public enum WdProofreadingErrorType
{
  /// <summary>
  /// Spelling error.
  /// </summary>
  wdSpellingError = unchecked((int)0),
  /// <summary>
  /// Grammatical error.
  /// </summary>
  wdGrammaticalError = unchecked((int)1)
}
