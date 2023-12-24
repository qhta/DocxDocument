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
    get => _Element?.EntityId;
    set => _ExistingElement.EntityId = value;
  }
  
  
  /// <summary>
  ///   GeoChildTypes.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoChildTypes? GeoChildTypes
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
