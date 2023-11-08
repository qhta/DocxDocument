namespace DocumentModel.Wordprocessing;


/// <summary>
///   Ignore Minimum Line Height for First Line on Page.
/// </summary>
public partial class SuppressSpacingAtTopOfPage: ModelElement<DXW.SuppressSpacingAtTopOfPage>
{
  public SuppressSpacingAtTopOfPage(): base(){ }
  
  public SuppressSpacingAtTopOfPage(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SuppressSpacingAtTopOfPage(DXW.SuppressSpacingAtTopOfPage openXmlElement): base(openXmlElement) { }
  
}
