namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of spelling and grammatical errors for the specified document or range.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.proofreadingerrors?view=word-pia"/>
public interface ProofreadingErrors : InteropObject, InteropCollection<Range>
{
  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.proofreadingerrors.type?view=word-pia"/>
  public WdProofreadingErrorType Type { get; }
}
