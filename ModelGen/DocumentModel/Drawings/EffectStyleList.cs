namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a set of three effect styles that create the effect style list for a theme.  The effect styles are arranged in order of subtle to moderate to intense.
/// </summary>
public partial class EffectStyleList: ModelElement<DXD.EffectStyleList>
{
  public EffectStyleList(): base(){ }
  
  public EffectStyleList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EffectStyleList(DXD.EffectStyleList openXmlElement): base(openXmlElement) { }
  
}
