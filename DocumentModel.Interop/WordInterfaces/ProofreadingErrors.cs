namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of spelling and grammatical errors for the specified document or range.
/// </summary>
public interface ProofreadingErrors : InteropObject, InteropCollection<Range>
{
  /// <summary>
  /// The type.
  /// </summary>
  public WdProofreadingErrorType Type { get; }
}
