namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a point in 3D space.  This point is the point in space that anchors the backdrop plane.
/// </summary>
public partial class Anchor: ModelElement<DXD.Anchor>
{
  public Anchor(): base(){ }
  
  public Anchor(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Anchor(DXD.Anchor openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   X-Coordinate in 3D space.
  /// </summary>
  [DataMember]
  public Int64? X
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   Y-Coordinate in 3D space.
  /// </summary>
  [DataMember]
  public Int64? Y
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   Z-Coordinate in 3D space.
  /// </summary>
  [DataMember]
  public Int64? Z
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
}
