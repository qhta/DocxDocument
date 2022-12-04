namespace DocumentModel.Wordprocessing;

/// <summary>
/// Spelling and Grammatical Checking State.
/// </summary>
public class ProofState
{
  /// <summary>
  /// Spell Checking State
  /// </summary>
  public ProofingStateKind? Spelling
  {
    get;
    set;
  }
  
  /// <summary>
  /// Grammatical Checking State
  /// </summary>
  public ProofingStateKind? Grammar
  {
    get;
    set;
  }
  
}
