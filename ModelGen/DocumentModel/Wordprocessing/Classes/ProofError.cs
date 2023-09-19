namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the ProofError Class.
/// </summary>
public partial class ProofError
{
  
  /// <summary>
  ///   Proofing Error Anchor Type
  /// </summary>
  [SchemaAttr("w:type")]
  public DocumentModel.Wordprocessing.ProofingErrorValues? Type { get; set; }
  
}
