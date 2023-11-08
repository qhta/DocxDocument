namespace DocumentModel.Wordprocessing;


/// <summary>
///   Automatically Update Styles From Document Template.
/// </summary>
public partial class LinkStyles: ModelElement<DXW.LinkStyles>
{
  public LinkStyles(): base(){ }
  
  public LinkStyles(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LinkStyles(DXW.LinkStyles openXmlElement): base(openXmlElement) { }
  
}
