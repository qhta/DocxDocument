namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Inline Drawing Object Extents.
/// </summary>
public partial class Extent: ModelElement<DXDW.Extent>
{
  public Extent(): base(){ }
  
  public Extent(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Extent(DXDW.Extent openXmlElement): base(openXmlElement) { }
  
  
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
