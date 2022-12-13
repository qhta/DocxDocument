namespace DocumentModel.Wordprocessing;

/// <summary>
/// Spelling and Grammatical Checking State.
/// </summary>
public interface ProofState
{
  /// <summary>
  /// Spell Checking State
  /// </summary>
  public DocumentModel.Wordprocessing.ProofingStateKind? Spelling { get ; set; }
  
  /// <summary>
  /// Grammatical Checking State
  /// </summary>
  public DocumentModel.Wordprocessing.ProofingStateKind? Grammar { get ; set; }
  
}
