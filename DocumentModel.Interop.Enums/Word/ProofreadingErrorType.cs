namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of proofreading error returned by the Word proofreading process.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdproofreadingerrortype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdProofreadingErrorType))]
public enum ProofreadingErrorType
{
  /// <summary>
  /// Spelling error.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdProofreadingErrorType.wdSpellingError))]
  SpellingError = 0,
  /// <summary>
  /// Grammatical error.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdProofreadingErrorType.wdGrammaticalError))]
  GrammaticalError = 1
}
