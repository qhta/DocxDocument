namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ProofError Class.
/// </summary>
public interface ProofError: IModelElement, ICommonContent
{
  /// <summary>
  ///   Proofing Error Anchor Type
  /// </summary>
  public ProofingErrorKind? Type { get; set; }
}