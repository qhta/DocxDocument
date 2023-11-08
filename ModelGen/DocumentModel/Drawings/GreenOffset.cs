namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the input color with its green component shifted, but with its red and blue color components unchanged.
/// </summary>
public partial class GreenOffset: ModelElement<DXD.GreenOffset>
{
  public GreenOffset(): base(){ }
  
  public GreenOffset(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GreenOffset(DXD.GreenOffset openXmlElement): base(openXmlElement) { }
  
}
