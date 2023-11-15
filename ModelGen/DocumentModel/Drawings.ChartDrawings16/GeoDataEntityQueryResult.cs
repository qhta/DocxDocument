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
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   GeoData.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoData? GeoData
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
