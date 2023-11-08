namespace DocumentModel.ExtendedProperties;


/// <summary>
///   Slides Metadata Element.
/// </summary>
public partial class Slides: ModelElement<DXEP.Slides>
{
  public Slides(): base(){ }
  
  public Slides(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Slides(DXEP.Slides openXmlElement): base(openXmlElement) { }
  
}
