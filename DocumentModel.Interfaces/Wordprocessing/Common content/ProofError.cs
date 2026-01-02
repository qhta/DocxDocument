namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ProofError Class.
/// </summary>
public class ProofError: ModelElement, ICommonContent
{
  /// <summary>
  ///   Proofing Error Anchor Type
  /// </summary>
  public ProofingErrorKind? Type { get; set; }
}