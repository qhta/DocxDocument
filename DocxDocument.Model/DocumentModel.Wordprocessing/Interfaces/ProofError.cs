namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ProofError Class.
/// </summary>
public partial interface ProofError
{
  /// <summary>
  /// Proofing Error Anchor Type
  /// </summary>
  public DocumentModel.Wordprocessing.ProofingErrorKind? Type { get; set; }
  
}
