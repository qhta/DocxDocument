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
      var element = _Element?.GetFirstChild<DXD.Blur>();
      if (element != null)
        return BlurConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Blur>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BlurConverter.CreateOpenXmlElement<DXD.Blur>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.FillOverlay>();
      if (element != null)
        return FillOverlayConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.FillOverlay>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillOverlayConverter.CreateOpenXmlElement<DXD.FillOverlay>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Glow>();
      if (element != null)
        return GlowConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Glow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GlowConverter.CreateOpenXmlElement<DXD.Glow>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.InnerShadow>();
      if (element != null)
        return InnerShadowConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.InnerShadow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = InnerShadowConverter.CreateOpenXmlElement<DXD.InnerShadow>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.OuterShadow>();
      if (element != null)
        return OuterShadowConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.OuterShadow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OuterShadowConverter.CreateOpenXmlElement<DXD.OuterShadow>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.PresetShadow>();
      if (element != null)
        return PresetShadowConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.PresetShadow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PresetShadowConverter.CreateOpenXmlElement<DXD.PresetShadow>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Reflection>();
      if (element != null)
        return ReflectionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Reflection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ReflectionConverter.CreateOpenXmlElement<DXD.Reflection>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.SoftEdge>();
      if (element != null)
        return SoftEdgeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.SoftEdge>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SoftEdgeConverter.CreateOpenXmlElement<DXD.SoftEdge>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
