namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Style Label.
/// </summary>
public partial class ColorTransformStyleLabel: ModelElement<DXDDD.ColorTransformStyleLabel>
{
  public ColorTransformStyleLabel(): base(){ }
  
  public ColorTransformStyleLabel(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorTransformStyleLabel(DXDDD.ColorTransformStyleLabel openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Name
  /// </summary>
  [DataMember]
  public String? Name
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Name);
    }
    set
    {
      _ExistingElement.Name = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Fill Color List.
  /// </summary>
  [DataMember]
  public DMDD.FillColorList? FillColorList
  {
    get
    {
      return _Element?.GetObject<DMDD.FillColorList,DXDDD.FillColorList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.FillColorList,DXDDD.FillColorList>(value);
    }
  }
  
  
  /// <summary>
  ///   Line Color List.
  /// </summary>
  [DataMember]
  public DMDD.LineColorList? LineColorList
  {
    get
    {
      return _Element?.GetObject<DMDD.LineColorList,DXDDD.LineColorList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.LineColorList,DXDDD.LineColorList>(value);
    }
  }
  
  
  /// <summary>
  ///   Effect Color List.
  /// </summary>
  [DataMember]
  public DMDD.EffectColorList? EffectColorList
  {
    get
    {
      return _Element?.GetObject<DMDD.EffectColorList,DXDDD.EffectColorList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.EffectColorList,DXDDD.EffectColorList>(value);
    }
  }
  
  
  /// <summary>
  ///   Text Line Color List.
  /// </summary>
  [DataMember]
  public DMDD.TextLineColorList? TextLineColorList
  {
    get
    {
      return _Element?.GetObject<DMDD.TextLineColorList,DXDDD.TextLineColorList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.TextLineColorList,DXDDD.TextLineColorList>(value);
    }
  }
  
  
  /// <summary>
  ///   Text Fill Color List.
  /// </summary>
  [DataMember]
  public DMDD.TextFillColorList? TextFillColorList
  {
    get
    {
      return _Element?.GetObject<DMDD.TextFillColorList,DXDDD.TextFillColorList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.TextFillColorList,DXDDD.TextFillColorList>(value);
    }
  }
  
  
  /// <summary>
  ///   Text Effect Color List.
  /// </summary>
  [DataMember]
  public DMDD.TextEffectColorList? TextEffectColorList
  {
    get
    {
      return _Element?.GetObject<DMDD.TextEffectColorList,DXDDD.TextEffectColorList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.TextEffectColorList,DXDDD.TextEffectColorList>(value);
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMDD.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDD.ExtensionList,DXDDD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.ExtensionList,DXDDD.ExtensionList>(value);
    }
  }
  
}
