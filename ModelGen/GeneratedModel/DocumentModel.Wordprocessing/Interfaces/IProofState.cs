namespace DocumentModel.Wordprocessing;

/// <summary>
/// Spelling and Grammatical Checking State.
/// </summary>
public interface IProofState // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Spell Checking State
  /// </summary>
  public ProofingState? Spelling { get ; set; }
  
  /// <summary>
  /// Grammatical Checking State
  /// </summary>
  public ProofingState? Grammar { get ; set; }
  
}
