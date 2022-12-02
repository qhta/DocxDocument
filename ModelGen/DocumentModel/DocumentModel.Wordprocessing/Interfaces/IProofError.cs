namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ProofError Class.
/// </summary>
public interface IProofError // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Proofing Error Anchor Type
  /// </summary>
  public ProofingErrorKind? Type { get ; set; }
  
}
