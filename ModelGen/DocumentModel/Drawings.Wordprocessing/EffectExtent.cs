namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Object Extents Including Effects.
/// </summary>
public partial class EffectExtent: ModelElement<DXDW.EffectExtent>
{
  public EffectExtent(): base(){ }
  
  public EffectExtent(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EffectExtent(DXDW.EffectExtent openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Additional Extent on Left Edge
  /// </summary>
  [DataMember]
  public Int64? LeftEdge
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   Additional Extent on Top Edge
  /// </summary>
  [DataMember]
  public Int64? TopEdge
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   Additional Extent on Right Edge
  /// </summary>
  [DataMember]
  public Int64? RightEdge
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   Additional Extent on Bottom Edge
  /// </summary>
  [DataMember]
  public Int64? BottomEdge
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
}
