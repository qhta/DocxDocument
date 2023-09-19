namespace DocumentModel.Wordprocessing;


/// <summary>
///   Spelling and Grammatical Checking State.
/// </summary>
public partial class ProofState
{
  
  /// <summary>
  ///   Spell Checking State
  /// </summary>
  [SchemaAttr("w:spelling")]
  public DocumentModel.Wordprocessing.ProofingStateValues? Spelling { get; set; }
  
  
  /// <summary>
  ///   Grammatical Checking State
  /// </summary>
  [SchemaAttr("w:grammar")]
  public DocumentModel.Wordprocessing.ProofingStateValues? Grammar { get; set; }
  
}
