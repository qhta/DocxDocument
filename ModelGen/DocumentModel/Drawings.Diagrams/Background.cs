namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Background Formatting.
/// </summary>
public partial class Background: ModelElement<DXDDD.Background>
{
  public Background(): base(){ }
  
  public Background(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Background(DXDDD.Background openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMD.NoFill? NoFill
  {
    get
    {
      return _Element?.GetObject<DMD.NoFill,DXD.NoFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.NoFill,DXD.NoFill>(value);
    }
  }
  
  [DataMember]
  public DMD.SolidFill? SolidFill
  {
    get
    {
      return _Element?.GetObject<DMD.SolidFill,DXD.SolidFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.SolidFill,DXD.SolidFill>(value);
    }
  }
  
  [DataMember]
  public DMD.GradientFill? GradientFill
  {
    get
    {
      return _Element?.GetObject<DMD.GradientFill,DXD.GradientFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.GradientFill,DXD.GradientFill>(value);
    }
  }
  
  [DataMember]
  public DMD.BlipFill? BlipFill
  {
    get
    {
      return _Element?.GetObject<DMD.BlipFill,DXD.BlipFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.BlipFill,DXD.BlipFill>(value);
    }
  }
  
  [DataMember]
  public DMD.PatternFill? PatternFill
  {
    get
    {
      return _Element?.GetObject<DMD.PatternFill,DXD.PatternFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.PatternFill,DXD.PatternFill>(value);
    }
  }
  
  [DataMember]
  public DMD.GroupFill? GroupFill
  {
    get
    {
      return _Element?.GetObject<DMD.GroupFill,DXD.GroupFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.GroupFill,DXD.GroupFill>(value);
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
