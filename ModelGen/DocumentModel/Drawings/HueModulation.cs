namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the input color with its hue modulated by the given percentage. A 50% hue modulate decreases the angular hue value by half. A 200% hue modulate doubles the angular hue value.
/// </summary>
public partial class HueModulation: ModelElement<DXD.HueModulation>
{
  public HueModulation(): base(){ }
  
  public HueModulation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HueModulation(DXD.HueModulation openXmlElement): base(openXmlElement) { }
  
}
