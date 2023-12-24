namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoData Class.
/// </summary>
public partial class GeoData: ModelElement<DXO16DCD.GeoData>
{
  public GeoData(): base(){ }
  
  public GeoData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoData(DXO16DCD.GeoData openXmlElement): base(openXmlElement) { }
  
  
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
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? EntityId
  {
    get => _Element?.EntityId;
    set => _ExistingElement.EntityId = value;
  }
  
  
  /// <summary>
  ///   east, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? East
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
  }
  
  
  /// <summary>
  ///   west, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? West
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
  }
  
  
  /// <summary>
  ///   north, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? North
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
  }
  
  
  /// <summary>
  ///   south, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? South
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
  }
  
  
  /// <summary>
  ///   GeoPolygons.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoPolygons? GeoPolygons
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Copyrights.
  /// </summary>
  [DataMember]
  public DMDCD16.Copyrights? Copyrights
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
