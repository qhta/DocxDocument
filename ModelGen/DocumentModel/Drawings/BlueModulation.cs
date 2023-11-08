namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the input color with its blue component modulated by the given percentage. A 50% blue modulate reduces the blue component by half. A 200% blue modulate doubles the blue component.
/// </summary>
public partial class BlueModulation: ModelElement<DXD.BlueModulation>
{
  public BlueModulation(): base(){ }
  
  public BlueModulation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BlueModulation(DXD.BlueModulation openXmlElement): base(openXmlElement) { }
  
}
