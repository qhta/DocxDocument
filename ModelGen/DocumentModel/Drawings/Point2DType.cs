namespace DocumentModel.Drawings;


/// <summary>
///   Defines the Point2DType Class.
/// </summary>
public partial class Point2DType: ModelElement<DXD.Point2DType>
{
  public Point2DType(): base(){ }
  
  public Point2DType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Point2DType(DXD.Point2DType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   X-Axis Coordinate
  /// </summary>
  [DataMember]
  public Int64? X
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   Y-Axis Coordinate
  /// </summary>
  [DataMember]
  public Int64? Y
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
}
