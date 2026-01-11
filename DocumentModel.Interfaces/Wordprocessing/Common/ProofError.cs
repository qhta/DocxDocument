namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a proofing error anchor in a WordprocessingML document.
/// This interface extends <see cref="CommonContent"/> and provides a property for the proofing error type, enabling advanced tracking and management of spelling, grammar, or other proofing errors within the document content.
/// </summary>
public interface ProofError : CommonContent
{
  
  /// <summary>
  /// Proofing error anchor type, specifying the kind of proofing error (e.g., spelling, grammar).
  /// </summary>
  public ProofingErrorKind? Type { get; set; }
}