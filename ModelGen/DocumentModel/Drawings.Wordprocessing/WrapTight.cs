namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Tight Wrapping.
/// </summary>
public partial class WrapTight: ModelElement<DXDW.WrapTight>
{
  public WrapTight(): base(){ }
  
  public WrapTight(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WrapTight(DXDW.WrapTight openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Distance From Test on Left Edge
  /// </summary>
  [DataMember]
  public UInt32? DistanceFromLeft
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   Distance From Text on Right Edge
  /// </summary>
  [DataMember]
  public UInt32? DistanceFromRight
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   Tight Wrapping Extents Polygon.
  /// </summary>
  [DataMember]
  public DMDW.WrapPolygon? WrapPolygon
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
