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
      return _Element?.GetObject<DMDCS.LineReference,DXO13DCS.LineReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.LineReference,DXO13DCS.LineReference>(value);
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
      return _Element?.GetObject<DMDCS.LineWidthScale,DXO13DCS.LineWidthScale>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.LineWidthScale,DXO13DCS.LineWidthScale>(value);
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
      return _Element?.GetObject<DMDCS.FillReference,DXO13DCS.FillReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.FillReference,DXO13DCS.FillReference>(value);
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
      return _Element?.GetObject<DMDCS.EffectReference,DXO13DCS.EffectReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.EffectReference,DXO13DCS.EffectReference>(value);
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
      return _Element?.GetObject<DMDCS.FontReference,DXO13DCS.FontReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.FontReference,DXO13DCS.FontReference>(value);
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
      return _Element?.GetObject<DMDCS.ShapeProperties,DXO13DCS.ShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.ShapeProperties,DXO13DCS.ShapeProperties>(value);
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
      return _Element?.GetObject<DMDCS.TextCharacterPropertiesType,DXO13DCS.TextCharacterPropertiesType>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.TextCharacterPropertiesType,DXO13DCS.TextCharacterPropertiesType>(value);
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
      return _Element?.GetObject<DMDCS.TextBodyProperties,DXO13DCS.TextBodyProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.TextBodyProperties,DXO13DCS.TextBodyProperties>(value);
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
      return _Element?.GetObject<DMDCS.OfficeArtExtensionList,DXO13DCS.OfficeArtExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.OfficeArtExtensionList,DXO13DCS.OfficeArtExtensionList>(value);
    }
  }
  
}
