namespace DocumentModel.Wordprocessing;


/// <summary>
///   Footer Reference.
/// </summary>
public partial class FooterReference: ModelElement<DXW.FooterReference>
{
  public FooterReference(): base(){ }
  
  public FooterReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FooterReference(DXW.FooterReference openXmlElement): base(openXmlElement) { }
  
}
