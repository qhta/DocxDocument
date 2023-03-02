namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ProofError Class.
/// </summary>
public record ProofError: CommonElement
{
  /// <summary>
  ///   Proofing Error Anchor Type
  /// </summary>
  public ProofingErrorKind? Type { get; set; }
}