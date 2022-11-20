namespace DocumentModel.Wordprocessing;

/// <summary>
/// Spelling and Grammatical Checking State.
/// </summary>
public class ProofState: IProofState
{
  /// <summary>
  /// Spell Checking State
  /// </summary>
  public ProofingStateValues? Spelling
  {
    get;
    set;
  }
  
  /// <summary>
  /// Grammatical Checking State
  /// </summary>
  public ProofingStateValues? Grammar
  {
    get;
    set;
  }
  
}
