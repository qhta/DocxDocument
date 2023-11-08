namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the input color with its saturation modulated by the given percentage. A 50% saturation modulate reduces the saturation by half. A 200% saturation modulate doubles the saturation.
/// </summary>
public partial class SaturationModulation: ModelElement<DXD.SaturationModulation>
{
  public SaturationModulation(): base(){ }
  
  public SaturationModulation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SaturationModulation(DXD.SaturationModulation openXmlElement): base(openXmlElement) { }
  
}
