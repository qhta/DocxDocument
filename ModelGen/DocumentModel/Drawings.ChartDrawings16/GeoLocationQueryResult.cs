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
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   GeoLocations.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoLocations? GeoLocations
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
