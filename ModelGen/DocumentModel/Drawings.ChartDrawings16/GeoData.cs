namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoData Class.
/// </summary>
public partial class GeoData: ModelElement<DXO16DCD.GeoData>
{
  public GeoData(): base(){ }
  
  public GeoData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoData(DXO16DCD.GeoData openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   entityName, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? EntityName
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.EntityName);
    }
    set
    {
      _ExistingElement.EntityName = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? EntityId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.EntityId);
    }
    set
    {
      _ExistingElement.EntityId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   east, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? East
  {
    get
    {
      return _Element?.East?.Value;
    }
    set
    {
      _ExistingElement.East = value;
    }
  }
  
  
  /// <summary>
  ///   west, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? West
  {
    get
    {
      return _Element?.West?.Value;
    }
    set
    {
      _ExistingElement.West = value;
    }
  }
  
  
  /// <summary>
  ///   north, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? North
  {
    get
    {
      return _Element?.North?.Value;
    }
    set
    {
      _ExistingElement.North = value;
    }
  }
  
  
  /// <summary>
  ///   south, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? South
  {
    get
    {
      return _Element?.South?.Value;
    }
    set
    {
      _ExistingElement.South = value;
    }
  }
  
  
  /// <summary>
  ///   GeoPolygons.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoPolygons? GeoPolygons
  {
    get
    {
      return _Element?.GetObject<DMDCD16.GeoPolygons,DXO16DCD.GeoPolygons>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.GeoPolygons,DXO16DCD.GeoPolygons>(value);
    }
  }
  
  
  /// <summary>
  ///   Copyrights.
  /// </summary>
  [DataMember]
  public DMDCD16.Copyrights? Copyrights
  {
    get
    {
      return _Element?.GetObject<DMDCD16.Copyrights,DXO16DCD.Copyrights>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.Copyrights,DXO16DCD.Copyrights>(value);
    }
  }
  
}
