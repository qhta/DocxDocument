namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoChildEntitiesQueryResult Class.
/// </summary>
public partial class GeoChildEntitiesQueryResult: ModelElement<DXO16DCD.GeoChildEntitiesQueryResult>
{
  public GeoChildEntitiesQueryResult(): base(){ }
  
  public GeoChildEntitiesQueryResult(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoChildEntitiesQueryResult(DXO16DCD.GeoChildEntitiesQueryResult openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GeoChildEntitiesQuery.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoChildEntitiesQuery? GeoChildEntitiesQuery
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   GeoChildEntities.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoChildEntities? GeoChildEntities
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
