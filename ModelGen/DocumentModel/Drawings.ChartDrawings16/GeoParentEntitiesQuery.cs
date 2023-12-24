namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoParentEntitiesQuery Class.
/// </summary>
public partial class GeoParentEntitiesQuery: ModelElement<DXO16DCD.GeoParentEntitiesQuery>
{
  public GeoParentEntitiesQuery(): base(){ }
  
  public GeoParentEntitiesQuery(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoParentEntitiesQuery(DXO16DCD.GeoParentEntitiesQuery openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? EntityId
  {
    get => _Element?.EntityId;
    set => _ExistingElement.EntityId = value;
  }
  
}
