namespace DocumentModel.Wordprocessing;

/// <summary>
/// Spelling and Grammatical Checking State.
/// </summary>
public interface IProofState // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Spell Checking State
  /// </summary>
  public ProofingStateValues? Spelling { get ; set; }
  
  /// <summary>
  /// Grammatical Checking State
  /// </summary>
  public ProofingStateValues? Grammar { get ; set; }
  
}
