namespace DocumentModel.Wordprocessing;


/// <summary>
///   Footer.
/// </summary>
public partial class Footer: ModelElement<DXW.Footer>
{
  public Footer(): base(){ }
  
  public Footer(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Footer(DXW.Footer openXmlElement): base(openXmlElement) { }
  
}
