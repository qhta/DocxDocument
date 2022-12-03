namespace DocumentModel.Wordprocessing;

/// <summary>
/// Spelling and Grammatical Checking State.
/// </summary>
public interface ProofState // : System.Boolean
{
  /// <summary>
  /// Spell Checking State
  /// </summary>
  public ProofingStateKind? Spelling { get ; set; }
  
  /// <summary>
  /// Grammatical Checking State
  /// </summary>
  public ProofingStateKind? Grammar { get ; set; }
  
}
