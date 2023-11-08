namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the ProofError Class.
/// </summary>
public partial class ProofError: ModelElement<DXW.ProofError>
{
  public ProofError(): base(){ }
  
  public ProofError(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ProofError(DXW.ProofError openXmlElement): base(openXmlElement) { }
  
}
