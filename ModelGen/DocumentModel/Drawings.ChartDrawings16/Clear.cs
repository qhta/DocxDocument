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
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   GeoDataEntityQueryResults.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoDataEntityQueryResults? GeoDataEntityQueryResults
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   GeoDataPointToEntityQueryResults.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoDataPointToEntityQueryResults? GeoDataPointToEntityQueryResults
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   GeoChildEntitiesQueryResults.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoChildEntitiesQueryResults? GeoChildEntitiesQueryResults
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   GeoParentEntitiesQueryResults.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoParentEntitiesQueryResults? GeoParentEntitiesQueryResults
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
