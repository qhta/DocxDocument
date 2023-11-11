namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Chart Space.
/// </summary>
public partial class ChartSpace: ModelElement<DXDC.ChartSpace>
{
  public ChartSpace(): base(){ }
  
  public ChartSpace(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChartSpace(DXDC.ChartSpace openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Date1904.
  /// </summary>
  [DataMember]
  public DMDC.Date1904? Date1904
  {
    get
    {
      return _Element?.GetObject<DMDC.Date1904,DXDC.Date1904>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Date1904,DXDC.Date1904>(value);
    }
  }
  
  
  /// <summary>
  ///   EditingLanguage.
  /// </summary>
  [DataMember]
  public String? EditingLanguage
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetFirstChild<DXDC.EditingLanguage>()?.Val);
    }
    set
    {
      StringValueConverter.SetValue<DXDC.EditingLanguage>(_ExistingElement, value);
    }
  }
  
  
  /// <summary>
  ///   RoundedCorners.
  /// </summary>
  [DataMember]
  public DMDC.RoundedCorners? RoundedCorners
  {
    get
    {
      return _Element?.GetObject<DMDC.RoundedCorners,DXDC.RoundedCorners>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.RoundedCorners,DXDC.RoundedCorners>(value);
    }
  }
  
  [DataMember]
  public Byte? Style
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXO10DC.Style>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXO10DC.Style,System.Byte>(_ExistingElement, value);
    }
  }
  
  [DataMember]
  public DMDC.ColorMapOverride? ColorMapOverride
  {
    get
    {
      return _Element?.GetObject<DMDC.ColorMapOverride,DXDC.ColorMapOverride>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ColorMapOverride,DXDC.ColorMapOverride>(value);
    }
  }
  
  [DataMember]
  public DMDC.PivotSource? PivotSource
  {
    get
    {
      return _Element?.GetObject<DMDC.PivotSource,DXDC.PivotSource>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.PivotSource,DXDC.PivotSource>(value);
    }
  }
  
  [DataMember]
  public DMDC.Protection? Protection
  {
    get
    {
      return _Element?.GetObject<DMDC.Protection,DXDC.Protection>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Protection,DXDC.Protection>(value);
    }
  }
  
  [DataMember]
  public DMDC.Chart? Chart
  {
    get
    {
      return _Element?.GetObject<DMDC.Chart,DXDC.Chart>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Chart,DXDC.Chart>(value);
    }
  }
  
  [DataMember]
  public DMDC.ShapeProperties? ShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDC.ShapeProperties,DXDC.ShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ShapeProperties,DXDC.ShapeProperties>(value);
    }
  }
  
  [DataMember]
  public DMDC.TextProperties? TextProperties
  {
    get
    {
      return _Element?.GetObject<DMDC.TextProperties,DXDC.TextProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.TextProperties,DXDC.TextProperties>(value);
    }
  }
  
  [DataMember]
  public DMDC.ExternalData? ExternalData
  {
    get
    {
      return _Element?.GetObject<DMDC.ExternalData,DXDC.ExternalData>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ExternalData,DXDC.ExternalData>(value);
    }
  }
  
  [DataMember]
  public DMDC.PrintSettings? PrintSettings
  {
    get
    {
      return _Element?.GetObject<DMDC.PrintSettings,DXDC.PrintSettings>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.PrintSettings,DXDC.PrintSettings>(value);
    }
  }
  
  [DataMember]
  public DMDC.UserShapesReference? UserShapesReference
  {
    get
    {
      return _Element?.GetObject<DMDC.UserShapesReference,DXDC.UserShapesReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.UserShapesReference,DXDC.UserShapesReference>(value);
    }
  }
  
  [DataMember]
  public DMDC.ChartSpaceExtensionList? ChartSpaceExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.ChartSpaceExtensionList,DXDC.ChartSpaceExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ChartSpaceExtensionList,DXDC.ChartSpaceExtensionList>(value);
    }
  }
  
}
