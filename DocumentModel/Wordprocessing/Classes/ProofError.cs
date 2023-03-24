namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ProofError Class.
/// </summary>
public class ProofError: ModelElement, ICommonElement
{
  /// <summary>
  ///   Proofing Error Anchor Type
  /// </summary>
  public ProofingErrorKind? Type { get; set; }
}