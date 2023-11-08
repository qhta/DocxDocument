namespace DocumentModel.ExtendedProperties;


/// <summary>
///   Thumbnail Display Mode.
/// </summary>
public partial class ScaleCrop: ModelElement<DXEP.ScaleCrop>
{
  public ScaleCrop(): base(){ }
  
  public ScaleCrop(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ScaleCrop(DXEP.ScaleCrop openXmlElement): base(openXmlElement) { }
  
}
