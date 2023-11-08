namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a list of effects. Effects are applied in the order specified by the container type (sibling or tree).
/// </summary>
public partial class EffectDag: ModelElement<DXD.EffectDag>
{
  public EffectDag(): base(){ }
  
  public EffectDag(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EffectDag(DXD.EffectDag openXmlElement): base(openXmlElement) { }
  
}
