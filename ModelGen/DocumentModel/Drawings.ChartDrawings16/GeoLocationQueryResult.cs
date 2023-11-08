namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoLocationQueryResult Class.
/// </summary>
public partial class GeoLocationQueryResult: ModelElement<DXO16DCD.GeoLocationQueryResult>
{
  public GeoLocationQueryResult(): base(){ }
  
  public GeoLocationQueryResult(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoLocationQueryResult(DXO16DCD.GeoLocationQueryResult openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GeoLocationQuery.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoLocationQuery? GeoLocationQuery
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.GeoLocationQuery>();
      if (element != null)
        return GeoLocationQueryConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.GeoLocationQuery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoLocationQueryConverter.CreateOpenXmlElement<DXO16DCD.GeoLocationQuery>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   GeoLocations.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoLocations? GeoLocations
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.GeoLocations>();
      if (element != null)
        return GeoLocationsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.GeoLocations>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoLocationsConverter.CreateOpenXmlElement<DXO16DCD.GeoLocations>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
