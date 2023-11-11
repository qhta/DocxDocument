namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the ChartSpace Class.
/// </summary>
public partial class ChartSpace: ModelElement<DXO16DCD.ChartSpace>
{
  public ChartSpace(): base(){ }
  
  public ChartSpace(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChartSpace(DXO16DCD.ChartSpace openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ChartData.
  /// </summary>
  [DataMember]
  public DMDCD16.ChartData? ChartData
  {
    get
    {
      return _Element?.GetObject<DMDCD16.ChartData,DXO16DCD.ChartData>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.ChartData,DXO16DCD.ChartData>(value);
    }
  }
  
  
  /// <summary>
  ///   Chart.
  /// </summary>
  [DataMember]
  public DMDCD16.Chart? Chart
  {
    get
    {
      return _Element?.GetObject<DMDCD16.Chart,DXO16DCD.Chart>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.Chart,DXO16DCD.Chart>(value);
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
  ///   TxPrTextBody.
  /// </summary>
  [DataMember]
  public DMDCD16.TxPrTextBody? TxPrTextBody
  {
    get
    {
      return _Element?.GetObject<DMDCD16.TxPrTextBody,DXO16DCD.TxPrTextBody>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.TxPrTextBody,DXO16DCD.TxPrTextBody>(value);
    }
  }
  
  
  /// <summary>
  ///   ColorMappingType.
  /// </summary>
  [DataMember]
  public DMDCD16.ColorMappingType? ColorMappingType
  {
    get
    {
      return _Element?.GetObject<DMDCD16.ColorMappingType,DXO16DCD.ColorMappingType>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.ColorMappingType,DXO16DCD.ColorMappingType>(value);
    }
  }
  
  
  /// <summary>
  ///   FormatOverrides.
  /// </summary>
  [DataMember]
  public DMDCD16.FormatOverrides? FormatOverrides
  {
    get
    {
      return _Element?.GetObject<DMDCD16.FormatOverrides,DXO16DCD.FormatOverrides>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.FormatOverrides,DXO16DCD.FormatOverrides>(value);
    }
  }
  
  
  /// <summary>
  ///   PrintSettings.
  /// </summary>
  [DataMember]
  public DMDCD16.PrintSettings? PrintSettings
  {
    get
    {
      return _Element?.GetObject<DMDCD16.PrintSettings,DXO16DCD.PrintSettings>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.PrintSettings,DXO16DCD.PrintSettings>(value);
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
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
