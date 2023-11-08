namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the input color with the specified red component, but with its green and blue color components unchanged.
/// </summary>
public partial class Red: ModelElement<DXD.Red>
{
  public Red(): base(){ }
  
  public Red(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Red(DXD.Red openXmlElement): base(openXmlElement) { }
  
}
