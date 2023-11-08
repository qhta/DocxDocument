namespace DocumentModel.Wordprocessing;


/// <summary>
///   Abstract Numbering Definition Identifier.
/// </summary>
public partial class Nsid: ModelElement<DXW.Nsid>
{
  public Nsid(): base(){ }
  
  public Nsid(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Nsid(DXW.Nsid openXmlElement): base(openXmlElement) { }
  
}
