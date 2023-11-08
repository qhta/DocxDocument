namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the input color with its red component shifted, but with its green and blue color components unchanged.
/// </summary>
public partial class RedOffset: ModelElement<DXD.RedOffset>
{
  public RedOffset(): base(){ }
  
  public RedOffset(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RedOffset(DXD.RedOffset openXmlElement): base(openXmlElement) { }
  
}
