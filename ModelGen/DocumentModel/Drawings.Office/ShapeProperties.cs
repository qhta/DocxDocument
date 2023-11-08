namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the ShapeProperties Class.
/// </summary>
public partial class ShapeProperties: ModelElement<DXOD.ShapeProperties>
{
  public ShapeProperties(): base(){ }
  
  public ShapeProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShapeProperties(DXOD.ShapeProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   2D Transform for Individual Objects.
  /// </summary>
  [DataMember]
  public DMD.Transform2D? Transform2D
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Transform2D>();
      if (element != null)
        return Transform2DConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Transform2D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Transform2DConverter.CreateOpenXmlElement<DXD.Transform2D>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.CustomGeometry? CustomGeometry
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.CustomGeometry>();
      if (element != null)
        return CustomGeometryConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.CustomGeometry>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CustomGeometryConverter.CreateOpenXmlElement<DXD.CustomGeometry>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.PresetGeometry? PresetGeometry
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.PresetGeometry>();
      if (element != null)
        return PresetGeometryConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.PresetGeometry>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PresetGeometryConverter.CreateOpenXmlElement<DXD.PresetGeometry>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.NoFill? NoFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.NoFill>();
      if (element != null)
        return NoFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.NoFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoFillConverter.CreateOpenXmlElement<DXD.NoFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.SolidFill? SolidFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.SolidFill>();
      if (element != null)
        return SolidFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.SolidFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SolidFillConverter.CreateOpenXmlElement<DXD.SolidFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.GradientFill? GradientFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.GradientFill>();
      if (element != null)
        return GradientFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.GradientFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GradientFillConverter.CreateOpenXmlElement<DXD.GradientFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.BlipFill? BlipFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.BlipFill>();
      if (element != null)
        return BlipFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.BlipFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BlipFillConverter.CreateOpenXmlElement<DXD.BlipFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.PatternFill? PatternFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.PatternFill>();
      if (element != null)
        return PatternFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.PatternFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PatternFillConverter.CreateOpenXmlElement<DXD.PatternFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.GroupFill? GroupFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.GroupFill>();
      if (element != null)
        return GroupFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.GroupFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GroupFillConverter.CreateOpenXmlElement<DXD.GroupFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.Outline? Outline
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Outline>();
      if (element != null)
        return OutlineConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Outline>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OutlineConverter.CreateOpenXmlElement<DXD.Outline>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.EffectList? EffectList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.EffectList>();
      if (element != null)
        return EffectListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.EffectList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectListConverter.CreateOpenXmlElement<DXD.EffectList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.EffectDag? EffectDag
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.EffectDag>();
      if (element != null)
        return EffectDagConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.EffectDag>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectDagConverter.CreateOpenXmlElement<DXD.EffectDag>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.Scene3DType? Scene3DType
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Scene3DType>();
      if (element != null)
        return Scene3DTypeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Scene3DType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Scene3DTypeConverter.CreateOpenXmlElement<DXD.Scene3DType>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.Shape3DType? Shape3DType
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Shape3DType>();
      if (element != null)
        return Shape3DTypeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Shape3DType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Shape3DTypeConverter.CreateOpenXmlElement<DXD.Shape3DType>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.ShapePropertiesExtensionList? ShapePropertiesExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ShapePropertiesExtensionList>();
      if (element != null)
        return ShapePropertiesExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ShapePropertiesExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesExtensionListConverter.CreateOpenXmlElement<DXD.ShapePropertiesExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
