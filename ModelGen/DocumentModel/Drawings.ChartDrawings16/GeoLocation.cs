namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoLocation Class.
/// </summary>
public partial class GeoLocation: ModelElement<DXO16DCD.GeoLocation>
{
  public GeoLocation(): base(){ }
  
  public GeoLocation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoLocation(DXO16DCD.GeoLocation openXmlElement): base(openXmlElement) { }
  
  
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
  
  
  /// <summary>
  ///   entityName, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? EntityName
  {
    get => _Element?.EntityName;
    set => _ExistingElement.EntityName = value;
  }
  
  
  /// <summary>
  ///   Address.
  /// </summary>
  [DataMember]
  public DMDCD16.Address? Address
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
}
