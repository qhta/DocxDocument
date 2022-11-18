namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ProofError Class.
/// </summary>
public interface IProofError // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Proofing Error Anchor Type
  /// </summary>
  public ProofingError? Type { get ; set; }
  
}
