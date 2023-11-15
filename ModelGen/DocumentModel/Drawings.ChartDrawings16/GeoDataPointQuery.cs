namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoDataPointQuery Class.
/// </summary>
public partial class GeoDataPointQuery: ModelElement<DXO16DCD.GeoDataPointQuery>
{
  public GeoDataPointQuery(): base(){ }
  
  public GeoDataPointQuery(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoDataPointQuery(DXO16DCD.GeoDataPointQuery openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   latitude, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? Latitude
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
  }
  
  
  /// <summary>
  ///   longitude, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? Longitude
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
  }
  
}
