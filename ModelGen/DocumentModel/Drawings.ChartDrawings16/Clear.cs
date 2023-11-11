namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Clear Class.
/// </summary>
public partial class Clear: ModelElement<DXO16DCD.Clear>
{
  public Clear(): base(){ }
  
  public Clear(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Clear(DXO16DCD.Clear openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GeoLocationQueryResults.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoLocationQueryResults? GeoLocationQueryResults
  {
    get
    {
      return _Element?.GetObject<DMDCD16.GeoLocationQueryResults,DXO16DCD.GeoLocationQueryResults>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.GeoLocationQueryResults,DXO16DCD.GeoLocationQueryResults>(value);
    }
  }
  
  
  /// <summary>
  ///   GeoDataEntityQueryResults.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoDataEntityQueryResults? GeoDataEntityQueryResults
  {
    get
    {
      return _Element?.GetObject<DMDCD16.GeoDataEntityQueryResults,DXO16DCD.GeoDataEntityQueryResults>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.GeoDataEntityQueryResults,DXO16DCD.GeoDataEntityQueryResults>(value);
    }
  }
  
  
  /// <summary>
  ///   GeoDataPointToEntityQueryResults.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoDataPointToEntityQueryResults? GeoDataPointToEntityQueryResults
  {
    get
    {
      return _Element?.GetObject<DMDCD16.GeoDataPointToEntityQueryResults,DXO16DCD.GeoDataPointToEntityQueryResults>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.GeoDataPointToEntityQueryResults,DXO16DCD.GeoDataPointToEntityQueryResults>(value);
    }
  }
  
  
  /// <summary>
  ///   GeoChildEntitiesQueryResults.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoChildEntitiesQueryResults? GeoChildEntitiesQueryResults
  {
    get
    {
      return _Element?.GetObject<DMDCD16.GeoChildEntitiesQueryResults,DXO16DCD.GeoChildEntitiesQueryResults>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.GeoChildEntitiesQueryResults,DXO16DCD.GeoChildEntitiesQueryResults>(value);
    }
  }
  
  
  /// <summary>
  ///   GeoParentEntitiesQueryResults.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoParentEntitiesQueryResults? GeoParentEntitiesQueryResults
  {
    get
    {
      return _Element?.GetObject<DMDCD16.GeoParentEntitiesQueryResults,DXO16DCD.GeoParentEntitiesQueryResults>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.GeoParentEntitiesQueryResults,DXO16DCD.GeoParentEntitiesQueryResults>(value);
    }
  }
  
}
