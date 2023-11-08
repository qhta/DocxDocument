namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the input color with its luminance shifted, but with its hue and saturation unchanged.
/// </summary>
public partial class LuminanceOffset: ModelElement<DXD.LuminanceOffset>
{
  public LuminanceOffset(): base(){ }
  
  public LuminanceOffset(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LuminanceOffset(DXD.LuminanceOffset openXmlElement): base(openXmlElement) { }
  
}
