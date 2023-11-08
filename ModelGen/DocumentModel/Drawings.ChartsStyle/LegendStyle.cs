namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the LegendStyle Class.
/// </summary>
public partial class LegendStyle: ModelElement<DXO13DCS.LegendStyle>
{
  public LegendStyle(): base(){ }
  
  public LegendStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LegendStyle(DXO13DCS.LegendStyle openXmlElement): base(openXmlElement) { }
  
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
