namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the input color with its red component modulated by the given percentage. A 50% red modulate reduces the red component by half. A 200% red modulate doubles the red component.
/// </summary>
public partial class RedModulation: ModelElement<DXD.RedModulation>
{
  public RedModulation(): base(){ }
  
  public RedModulation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RedModulation(DXD.RedModulation openXmlElement): base(openXmlElement) { }
  
}
