namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of proofreading error returned by the Word proofreading process.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdproofreadingerrortype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdProofreadingErrorType")]
public enum ProofreadingErrorType
{
  /// <summary>
  /// Spelling error.
  /// </summary>
  [InteropEnumValue("wdSpellingError")]
  SpellingError = 0,
  /// <summary>
  /// Grammatical error.
  /// </summary>
  [InteropEnumValue("wdGrammaticalError")]
  GrammaticalError = 1
}
