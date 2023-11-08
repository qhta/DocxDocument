namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the input color with the specified luminance, but with its hue and saturation unchanged. Typically luminance values fall in the range [0%, 100%].
/// </summary>
public partial class Luminance: ModelElement<DXD.Luminance>
{
  public Luminance(): base(){ }
  
  public Luminance(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Luminance(DXD.Luminance openXmlElement): base(openXmlElement) { }
  
}
