namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a reference to an effect style within the style matrix.  The idx attribute refers the index of an effect style within the effectStyleLst element.
/// </summary>
public partial class EffectReference: ModelElement<DXD.EffectReference>
{
  public EffectReference(): base(){ }
  
  public EffectReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EffectReference(DXD.EffectReference openXmlElement): base(openXmlElement) { }
  
}
