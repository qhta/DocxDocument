namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of proofreading error returned by the Word proofreading process.
/// </summary>
public enum WdProofreadingErrorType
{
  /// <summary>
  /// Spelling error.
  /// </summary>
  SpellingError = 0,
  /// <summary>
  /// Grammatical error.
  /// </summary>
  GrammaticalError = 1
}
