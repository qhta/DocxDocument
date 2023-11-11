namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the TrendlineLabel Class.
/// </summary>
public partial class TrendlineLabel: ModelElement<DXO13DCS.TrendlineLabel>
{
  public TrendlineLabel(): base(){ }
  
  public TrendlineLabel(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TrendlineLabel(DXO13DCS.TrendlineLabel openXmlElement): base(openXmlElement) { }
  
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
