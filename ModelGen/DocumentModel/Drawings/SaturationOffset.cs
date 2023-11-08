namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the input color with its saturation shifted, but with its hue and luminance unchanged. A 10% offset to 20% saturation yields 30% saturation.
/// </summary>
public partial class SaturationOffset: ModelElement<DXD.SaturationOffset>
{
  public SaturationOffset(): base(){ }
  
  public SaturationOffset(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SaturationOffset(DXD.SaturationOffset openXmlElement): base(openXmlElement) { }
  
}
