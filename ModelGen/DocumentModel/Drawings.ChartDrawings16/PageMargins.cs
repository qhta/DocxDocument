namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the PageMargins Class.
/// </summary>
public partial class PageMargins: ModelElement<DXO16DCD.PageMargins>
{
  public PageMargins(): base(){ }
  
  public PageMargins(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PageMargins(DXO16DCD.PageMargins openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   l, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? L
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
  }
  
  
  /// <summary>
  ///   r, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? R
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
  }
  
  
  /// <summary>
  ///   t, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? T
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
  }
  
  
  /// <summary>
  ///   b, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? B
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
  }
  
  
  /// <summary>
  ///   header, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? Header
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
  }
  
  
  /// <summary>
  ///   footer, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? Footer
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
  }
  
}
