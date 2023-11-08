namespace DocumentModel.Wordprocessing;


/// <summary>
///   Data for HTML body Element.
/// </summary>
public partial class BodyDiv: ModelElement<DXW.BodyDiv>
{
  public BodyDiv(): base(){ }
  
  public BodyDiv(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BodyDiv(DXW.BodyDiv openXmlElement): base(openXmlElement) { }
  
}
