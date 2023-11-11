namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ShapeProperties Class.
/// </summary>
public partial class ShapeProperties: ModelElement<DXDC.ShapeProperties>
{
  public ShapeProperties(): base(){ }
  
  public ShapeProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShapeProperties(DXDC.ShapeProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   2D Transform for Individual Objects.
  /// </summary>
  [DataMember]
  public DMD.Transform2D? Transform2D
  {
    get
    {
      return _Element?.GetObject<DMD.Transform2D,DXD.Transform2D>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Transform2D,DXD.Transform2D>(value);
    }
  }
  
  [DataMember]
  public DMD.CustomGeometry? CustomGeometry
  {
    get
    {
      return _Element?.GetObject<DMD.CustomGeometry,DXD.CustomGeometry>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.CustomGeometry,DXD.CustomGeometry>(value);
    }
  }
  
  [DataMember]
  public DMD.PresetGeometry? PresetGeometry
  {
    get
    {
      return _Element?.GetObject<DMD.PresetGeometry,DXD.PresetGeometry>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.PresetGeometry,DXD.PresetGeometry>(value);
    }
  }
  
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
  
  [DataMember]
  public DMD.Scene3DType? Scene3DType
  {
    get
    {
      return _Element?.GetObject<DMD.Scene3DType,DXD.Scene3DType>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Scene3DType,DXD.Scene3DType>(value);
    }
  }
  
  [DataMember]
  public DMD.Shape3DType? Shape3DType
  {
    get
    {
      return _Element?.GetObject<DMD.Shape3DType,DXD.Shape3DType>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Shape3DType,DXD.Shape3DType>(value);
    }
  }
  
  [DataMember]
  public DMD.ShapePropertiesExtensionList? ShapePropertiesExtensionList
  {
    get
    {
      return _Element?.GetObject<DMD.ShapePropertiesExtensionList,DXD.ShapePropertiesExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ShapePropertiesExtensionList,DXD.ShapePropertiesExtensionList>(value);
    }
  }
  
}
