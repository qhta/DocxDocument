namespace DocumentModel.Drawings;


/// <summary>
///   Defines the Vector3DType Class.
/// </summary>
public partial class Vector3DType: ModelElement<DXD.Vector3DType>
{
  public Vector3DType(): base(){ }
  
  public Vector3DType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Vector3DType(DXD.Vector3DType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Distance along X-axis in 3D
  /// </summary>
  [DataMember]
  public Int64? Dx
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   Distance along Y-axis in 3D
  /// </summary>
  [DataMember]
  public Int64? Dy
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   Distance along Z-axis in 3D
  /// </summary>
  [DataMember]
  public Int64? Dz
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
}
