namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the input color with the specific blue component, but with the red and green color components unchanged.
/// </summary>
public partial class Blue: ModelElement<DXD.Blue>
{
  public Blue(): base(){ }
  
  public Blue(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Blue(DXD.Blue openXmlElement): base(openXmlElement) { }
  
}
