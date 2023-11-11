namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoDataEntityQueryResult Class.
/// </summary>
public partial class GeoDataEntityQueryResult: ModelElement<DXO16DCD.GeoDataEntityQueryResult>
{
  public GeoDataEntityQueryResult(): base(){ }
  
  public GeoDataEntityQueryResult(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoDataEntityQueryResult(DXO16DCD.GeoDataEntityQueryResult openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GeoDataEntityQuery.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoDataEntityQuery? GeoDataEntityQuery
  {
    get
    {
      return _Element?.GetObject<DMDCD16.GeoDataEntityQuery,DXO16DCD.GeoDataEntityQuery>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.GeoDataEntityQuery,DXO16DCD.GeoDataEntityQuery>(value);
    }
  }
  
  
  /// <summary>
  ///   GeoData.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoData? GeoData
  {
    get
    {
      return _Element?.GetObject<DMDCD16.GeoData,DXO16DCD.GeoData>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.GeoData,DXO16DCD.GeoData>(value);
    }
  }
  
}
