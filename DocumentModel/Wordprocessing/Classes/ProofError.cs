namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ProofError Class.
/// </summary>
public class ProofError: CommonElement
{
  /// <summary>
  ///   Proofing Error Anchor Type
  /// </summary>
  public ProofingErrorKind? Type { get; set; }
}