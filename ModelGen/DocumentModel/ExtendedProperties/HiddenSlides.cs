namespace DocumentModel.ExtendedProperties;


/// <summary>
///   Number of Hidden Slides.
/// </summary>
public partial class HiddenSlides: ModelElement<DXEP.HiddenSlides>
{
  public HiddenSlides(): base(){ }
  
  public HiddenSlides(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HiddenSlides(DXEP.HiddenSlides openXmlElement): base(openXmlElement) { }
  
}
