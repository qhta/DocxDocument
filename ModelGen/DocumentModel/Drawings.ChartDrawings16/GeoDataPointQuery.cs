namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoDataPointQuery Class.
/// </summary>
public partial class GeoDataPointQuery: ModelElement<DXO16DCD.GeoDataPointQuery>
{
  public GeoDataPointQuery(): base(){ }
  
  public GeoDataPointQuery(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoDataPointQuery(DXO16DCD.GeoDataPointQuery openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   latitude, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? Latitude
  {
    get
    {
      return _Element?.Latitude?.Value;
    }
    set
    {
      _ExistingElement.Latitude = value;
    }
  }
  
  
  /// <summary>
  ///   longitude, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? Longitude
  {
    get
    {
      return _Element?.Longitude?.Value;
    }
    set
    {
      _ExistingElement.Longitude = value;
    }
  }
  
}
