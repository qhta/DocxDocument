namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PageSize Class.
/// </summary>
public partial class PageSize: ModelElement<DXW.PageSize>
{
  public PageSize(): base(){ }
  
  public PageSize(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PageSize(DXW.PageSize openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Page Width
  /// </summary>
  [DataMember]
  public UInt32? Width
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   Page Height
  /// </summary>
  [DataMember]
  public UInt32? Height
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   Printer Paper Code
  /// </summary>
  [DataMember]
  public UInt16? Code
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt16]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt16]");
  }
  
}
