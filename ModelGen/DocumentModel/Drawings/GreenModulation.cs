namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the input color with its green component modulated by the given percentage. A 50% green modulate reduces the green component by half. A 200% green modulate doubles the green component.
/// </summary>
public partial class GreenModulation: ModelElement<DXD.GreenModulation>
{
  public GreenModulation(): base(){ }
  
  public GreenModulation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GreenModulation(DXD.GreenModulation openXmlElement): base(openXmlElement) { }
  
}
