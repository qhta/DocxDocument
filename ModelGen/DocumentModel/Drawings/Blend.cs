namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a blend of several effects. The container specifies the raw effects to blend while the blend mode specifies how the effects are to be blended.
/// </summary>
public partial class Blend: ModelElement<DXD.Blend>
{
  public Blend(): base(){ }
  
  public Blend(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Blend(DXD.Blend openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Effect to blend.
  /// </summary>
  [DataMember]
  public DMD.EffectContainer? EffectContainer
  {
    get
    {
      return _Element?.GetObject<DMD.EffectContainer,DXD.EffectContainer>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.EffectContainer,DXD.EffectContainer>(value);
    }
  }
  
}
