namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the input color with its blue component shifted, but with its red and green color components unchanged.
/// </summary>
public partial class BlueOffset: ModelElement<DXD.BlueOffset>
{
  public BlueOffset(): base(){ }
  
  public BlueOffset(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BlueOffset(DXD.BlueOffset openXmlElement): base(openXmlElement) { }
  
}
