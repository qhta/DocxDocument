namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoDataPointToEntityQueryResult Class.
/// </summary>
public partial class GeoDataPointToEntityQueryResult: ModelElement<DXO16DCD.GeoDataPointToEntityQueryResult>
{
  public GeoDataPointToEntityQueryResult(): base(){ }
  
  public GeoDataPointToEntityQueryResult(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoDataPointToEntityQueryResult(DXO16DCD.GeoDataPointToEntityQueryResult openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GeoDataPointQuery.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoDataPointQuery? GeoDataPointQuery
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   GeoDataPointToEntityQuery.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoDataPointToEntityQuery? GeoDataPointToEntityQuery
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
}
