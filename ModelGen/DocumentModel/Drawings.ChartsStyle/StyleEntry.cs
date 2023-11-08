namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the StyleEntry Class.
/// </summary>
public partial class StyleEntry: ModelElement<DXO13DCS.StyleEntry>
{
  public StyleEntry(): base(){ }
  
  public StyleEntry(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleEntry(DXO13DCS.StyleEntry openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   mods, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public DM.ListOf<String>? Modifiers
  {
    get
    {
      return ListValueConverter.GetValue(_Element?.Modifiers);
    }
    set
    {
      if (value != null)
        _ExistingElement.Modifiers = ListValueConverter.CreateListValue<DX.StringValue>(value);
      else
        _ExistingElement.Modifiers = null;
    }
  }
  
  
  /// <summary>
  ///   LineReference.
  /// </summary>
  [DataMember]
  public DMDCS.LineReference? LineReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DCS.LineReference>();
      if (element != null)
        return LineReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.LineReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineReferenceConverter.CreateOpenXmlElement<DXO13DCS.LineReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   LineWidthScale.
  /// </summary>
  [DataMember]
  public DMDCS.LineWidthScale? LineWidthScale
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DCS.LineWidthScale>();
      if (element != null)
        return LineWidthScaleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.LineWidthScale>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineWidthScaleConverter.CreateOpenXmlElement<DXO13DCS.LineWidthScale>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   FillReference.
  /// </summary>
  [DataMember]
  public DMDCS.FillReference? FillReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DCS.FillReference>();
      if (element != null)
        return FillReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.FillReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillReferenceConverter.CreateOpenXmlElement<DXO13DCS.FillReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   EffectReference.
  /// </summary>
  [DataMember]
  public DMDCS.EffectReference? EffectReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DCS.EffectReference>();
      if (element != null)
        return EffectReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.EffectReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectReferenceConverter.CreateOpenXmlElement<DXO13DCS.EffectReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   FontReference.
  /// </summary>
  [DataMember]
  public DMDCS.FontReference? FontReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DCS.FontReference>();
      if (element != null)
        return FontReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.FontReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FontReferenceConverter.CreateOpenXmlElement<DXO13DCS.FontReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  [DataMember]
  public DMDCS.ShapeProperties? ShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DCS.ShapeProperties>();
      if (element != null)
        return ShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DXO13DCS.ShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   TextCharacterPropertiesType.
  /// </summary>
  [DataMember]
  public DMDCS.TextCharacterPropertiesType? TextCharacterPropertiesType
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DCS.TextCharacterPropertiesType>();
      if (element != null)
        return TextCharacterPropertiesTypeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.TextCharacterPropertiesType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextCharacterPropertiesTypeConverter.CreateOpenXmlElement<DXO13DCS.TextCharacterPropertiesType>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   TextBodyProperties.
  /// </summary>
  [DataMember]
  public DMDCS.TextBodyProperties? TextBodyProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DCS.TextBodyProperties>();
      if (element != null)
        return TextBodyPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.TextBodyProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextBodyPropertiesConverter.CreateOpenXmlElement<DXO13DCS.TextBodyProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMDCS.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DCS.OfficeArtExtensionList>();
      if (element != null)
        return OfficeArtExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO13DCS.OfficeArtExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
