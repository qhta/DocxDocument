namespace DocumentModel.Wordprocessing;


/// <summary>
///   Spelling and Grammatical Checking State.
/// </summary>
public partial class ProofState: ModelElement<DXW.ProofState>
{
  public ProofState(): base(){ }
  
  public ProofState(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ProofState(DXW.ProofState openXmlElement): base(openXmlElement) { }
  
}
