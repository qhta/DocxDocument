namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the input color with its luminance modulated by the given percentage. A 50% luminance modulate reduces the luminance by half. A 200% luminance modulate doubles the luminance.
/// </summary>
public partial class LuminanceModulation: ModelElement<DXD.LuminanceModulation>
{
  public LuminanceModulation(): base(){ }
  
  public LuminanceModulation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LuminanceModulation(DXD.LuminanceModulation openXmlElement): base(openXmlElement) { }
  
}
