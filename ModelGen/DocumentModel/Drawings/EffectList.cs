namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a list of effects. Effects in an effectLst are applied in the default order by the rendering engine. The following diagrams illustrate the order in which effects are applied, both for shapes and for group shapes.
/// </summary>
public partial class EffectList: ModelElement<DXD.EffectList>
{
  public EffectList(): base(){ }
  
  public EffectList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EffectList(DXD.EffectList openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Blur Effect.
  /// </summary>
  [DataMember]
  public DMD.Blur? Blur
  {
    get
    {
      return _Element?.GetObject<DMD.Blur,DXD.Blur>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Blur,DXD.Blur>(value);
    }
  }
  
  
  /// <summary>
  ///   FillOverlay.
  /// </summary>
  [DataMember]
  public DMD.FillOverlay? FillOverlay
  {
    get
    {
      return _Element?.GetObject<DMD.FillOverlay,DXD.FillOverlay>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.FillOverlay,DXD.FillOverlay>(value);
    }
  }
  
  
  /// <summary>
  ///   Glow.
  /// </summary>
  [DataMember]
  public DMD.Glow? Glow
  {
    get
    {
      return _Element?.GetObject<DMD.Glow,DXD.Glow>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Glow,DXD.Glow>(value);
    }
  }
  
  
  /// <summary>
  ///   InnerShadow.
  /// </summary>
  [DataMember]
  public DMD.InnerShadow? InnerShadow
  {
    get
    {
      return _Element?.GetObject<DMD.InnerShadow,DXD.InnerShadow>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.InnerShadow,DXD.InnerShadow>(value);
    }
  }
  
  
  /// <summary>
  ///   OuterShadow.
  /// </summary>
  [DataMember]
  public DMD.OuterShadow? OuterShadow
  {
    get
    {
      return _Element?.GetObject<DMD.OuterShadow,DXD.OuterShadow>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.OuterShadow,DXD.OuterShadow>(value);
    }
  }
  
  
  /// <summary>
  ///   PresetShadow.
  /// </summary>
  [DataMember]
  public DMD.PresetShadow? PresetShadow
  {
    get
    {
      return _Element?.GetObject<DMD.PresetShadow,DXD.PresetShadow>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.PresetShadow,DXD.PresetShadow>(value);
    }
  }
  
  
  /// <summary>
  ///   Reflection.
  /// </summary>
  [DataMember]
  public DMD.Reflection? Reflection
  {
    get
    {
      return _Element?.GetObject<DMD.Reflection,DXD.Reflection>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Reflection,DXD.Reflection>(value);
    }
  }
  
  
  /// <summary>
  ///   SoftEdge.
  /// </summary>
  [DataMember]
  public DMD.SoftEdge? SoftEdge
  {
    get
    {
      return _Element?.GetObject<DMD.SoftEdge,DXD.SoftEdge>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.SoftEdge,DXD.SoftEdge>(value);
    }
  }
  
}
