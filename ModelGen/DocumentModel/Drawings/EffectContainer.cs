namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an Effect Container. It is a list of effects.
/// </summary>
public partial class EffectContainer: ModelElement<DXD.EffectContainer>
{
  public EffectContainer(): base(){ }
  
  public EffectContainer(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EffectContainer(DXD.EffectContainer openXmlElement): base(openXmlElement) { }
  
}
