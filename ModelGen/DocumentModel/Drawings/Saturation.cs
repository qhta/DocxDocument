namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the input color with the specified saturation, but with its hue and luminance unchanged. Typically saturation values fall in the range [0%, 100%].
/// </summary>
public partial class Saturation: ModelElement<DXD.Saturation>
{
  public Saturation(): base(){ }
  
  public Saturation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Saturation(DXD.Saturation openXmlElement): base(openXmlElement) { }
  
}
