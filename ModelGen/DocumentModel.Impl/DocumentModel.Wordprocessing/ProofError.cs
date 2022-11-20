namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ProofError Class.
/// </summary>
public class ProofError: IProofError
{
  /// <summary>
  /// Proofing Error Anchor Type
  /// </summary>
  public ProofingErrorValues? Type
  {
    get;
    set;
  }
  
}
