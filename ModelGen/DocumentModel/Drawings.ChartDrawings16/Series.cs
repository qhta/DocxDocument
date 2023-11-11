namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Series Class.
/// </summary>
public partial class Series: ModelElement<DXO16DCD.Series>
{
  public Series(): base(){ }
  
  public Series(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Series(DXO16DCD.Series openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   hidden, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? Hidden
  {
    get
    {
      return _Element?.Hidden?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Hidden = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Hidden = null;
    }
  }
  
  
  /// <summary>
  ///   ownerIdx, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public UInt32? OwnerIdx
  {
    get
    {
      return _Element?.OwnerIdx?.Value;
    }
    set
    {
      _ExistingElement.OwnerIdx = value;
    }
  }
  
  
  /// <summary>
  ///   uniqueId, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? UniqueId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.UniqueId);
    }
    set
    {
      _ExistingElement.UniqueId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   formatIdx, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public UInt32? FormatIdx
  {
    get
    {
      return _Element?.FormatIdx?.Value;
    }
    set
    {
      _ExistingElement.FormatIdx = value;
    }
  }
  
  
  /// <summary>
  ///   Text.
  /// </summary>
  [DataMember]
  public DMDCD16.Text? Text
  {
    get
    {
      return _Element?.GetObject<DMDCD16.Text,DXO16DCD.Text>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.Text,DXO16DCD.Text>(value);
    }
  }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  [DataMember]
  public DMDCD16.ShapeProperties? ShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD16.ShapeProperties,DXO16DCD.ShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.ShapeProperties,DXO16DCD.ShapeProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   ValueColors.
  /// </summary>
  [DataMember]
  public DMDCD16.ValueColors? ValueColors
  {
    get
    {
      return _Element?.GetObject<DMDCD16.ValueColors,DXO16DCD.ValueColors>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.ValueColors,DXO16DCD.ValueColors>(value);
    }
  }
  
  
  /// <summary>
  ///   ValueColorPositions.
  /// </summary>
  [DataMember]
  public DMDCD16.ValueColorPositions? ValueColorPositions
  {
    get
    {
      return _Element?.GetObject<DMDCD16.ValueColorPositions,DXO16DCD.ValueColorPositions>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.ValueColorPositions,DXO16DCD.ValueColorPositions>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.DataLabels? DataLabels
  {
    get
    {
      return _Element?.GetObject<DMDCD16.DataLabels,DXO16DCD.DataLabels>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.DataLabels,DXO16DCD.DataLabels>(value);
    }
  }
  
  [DataMember]
  public UInt32? DataId
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXO16DCD.DataId>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXO16DCD.DataId,System.UInt32>(_ExistingElement, value);
    }
  }
  
  [DataMember]
  public DMDCD16.SeriesLayoutProperties? SeriesLayoutProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD16.SeriesLayoutProperties,DXO16DCD.SeriesLayoutProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.SeriesLayoutProperties,DXO16DCD.SeriesLayoutProperties>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDCD16.ExtensionList,DXO16DCD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.ExtensionList,DXO16DCD.ExtensionList>(value);
    }
  }
  
}
