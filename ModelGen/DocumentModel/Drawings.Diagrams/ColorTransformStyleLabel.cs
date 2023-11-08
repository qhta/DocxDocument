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
      var element = _Element?.GetFirstChild<DXDDD.FillColorList>();
      if (element != null)
        return FillColorListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.FillColorList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillColorListConverter.CreateOpenXmlElement<DXDDD.FillColorList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDDD.LineColorList>();
      if (element != null)
        return LineColorListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.LineColorList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineColorListConverter.CreateOpenXmlElement<DXDDD.LineColorList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDDD.EffectColorList>();
      if (element != null)
        return EffectColorListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.EffectColorList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectColorListConverter.CreateOpenXmlElement<DXDDD.EffectColorList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDDD.TextLineColorList>();
      if (element != null)
        return TextLineColorListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.TextLineColorList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextLineColorListConverter.CreateOpenXmlElement<DXDDD.TextLineColorList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDDD.TextFillColorList>();
      if (element != null)
        return TextFillColorListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.TextFillColorList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextFillColorListConverter.CreateOpenXmlElement<DXDDD.TextFillColorList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDDD.TextEffectColorList>();
      if (element != null)
        return TextEffectColorListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.TextEffectColorList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextEffectColorListConverter.CreateOpenXmlElement<DXDDD.TextEffectColorList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDDD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXDDD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
