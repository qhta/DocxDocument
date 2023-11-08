namespace DocumentModel.ExtendedProperties;


/// <summary>
///   Total Number of Pages.
/// </summary>
public partial class Pages: ModelElement<DXEP.Pages>
{
  public Pages(): base(){ }
  
  public Pages(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Pages(DXEP.Pages openXmlElement): base(openXmlElement) { }
  
}
