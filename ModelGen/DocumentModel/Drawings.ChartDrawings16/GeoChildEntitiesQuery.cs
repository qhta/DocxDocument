namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoChildEntitiesQuery Class.
/// </summary>
public partial class GeoChildEntitiesQuery: ModelElement<DXO16DCD.GeoChildEntitiesQuery>
{
  public GeoChildEntitiesQuery(): base(){ }
  
  public GeoChildEntitiesQuery(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoChildEntitiesQuery(DXO16DCD.GeoChildEntitiesQuery openXmlElement): base(openXmlElement) { }
  
  
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
  ///   GeoChildTypes.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoChildTypes? GeoChildTypes
  {
    get
    {
      return _Element?.GetObject<DMDCD16.GeoChildTypes,DXO16DCD.GeoChildTypes>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.GeoChildTypes,DXO16DCD.GeoChildTypes>(value);
    }
  }
  
}
