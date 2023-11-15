namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoParentEntitiesQueryResult Class.
/// </summary>
public partial class GeoParentEntitiesQueryResult: ModelElement<DXO16DCD.GeoParentEntitiesQueryResult>
{
  public GeoParentEntitiesQueryResult(): base(){ }
  
  public GeoParentEntitiesQueryResult(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoParentEntitiesQueryResult(DXO16DCD.GeoParentEntitiesQueryResult openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GeoParentEntitiesQuery.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoParentEntitiesQuery? GeoParentEntitiesQuery
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   GeoEntity.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoEntity? GeoEntity
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   GeoParentEntity.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoParentEntity? GeoParentEntity
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
}
