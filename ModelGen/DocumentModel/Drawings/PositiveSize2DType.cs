namespace DocumentModel.Drawings;


/// <summary>
///   Defines the PositiveSize2DType Class.
/// </summary>
public partial class PositiveSize2DType: ModelElement<DXD.PositiveSize2DType>
{
  public PositiveSize2DType(): base(){ }
  
  public PositiveSize2DType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PositiveSize2DType(DXD.PositiveSize2DType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Extent Length
  /// </summary>
  [DataMember]
  public Int64? Cx
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   Extent Width
  /// </summary>
  [DataMember]
  public Int64? Cy
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
}
