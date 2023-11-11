namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the HiddenEffectsProperties Class.
/// </summary>
public partial class HiddenEffectsProperties: ModelElement<DXO10D.HiddenEffectsProperties>
{
  public HiddenEffectsProperties(): base(){ }
  
  public HiddenEffectsProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HiddenEffectsProperties(DXO10D.HiddenEffectsProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Effect Container.
  /// </summary>
  [DataMember]
  public DMD.EffectList? EffectList
  {
    get
    {
      return _Element?.GetObject<DMD.EffectList,DXD.EffectList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.EffectList,DXD.EffectList>(value);
    }
  }
  
  
  /// <summary>
  ///   Effect Container.
  /// </summary>
  [DataMember]
  public DMD.EffectDag? EffectDag
  {
    get
    {
      return _Element?.GetObject<DMD.EffectDag,DXD.EffectDag>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.EffectDag,DXD.EffectDag>(value);
    }
  }
  
}
