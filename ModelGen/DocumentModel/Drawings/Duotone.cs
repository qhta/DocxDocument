namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a duotone effect.
/// </summary>
public partial class Duotone: ModelElement<DXD.Duotone>
{
  public Duotone(): base(){ }
  
  public Duotone(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Duotone(DXD.Duotone openXmlElement): base(openXmlElement) { }
  
}
