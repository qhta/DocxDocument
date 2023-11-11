namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Whole E2O Formatting.
/// </summary>
public partial class Whole: ModelElement<DXDDD.Whole>
{
  public Whole(): base(){ }
  
  public Whole(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Whole(DXDDD.Whole openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Outline.
  /// </summary>
  [DataMember]
  public DMD.Outline? Outline
  {
    get
    {
      return _Element?.GetObject<DMD.Outline,DXD.Outline>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Outline,DXD.Outline>(value);
    }
  }
  
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
