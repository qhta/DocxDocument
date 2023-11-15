namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PageMargin Class.
/// </summary>
public partial class PageMargin: ModelElement<DXW.PageMargin>
{
  public PageMargin(): base(){ }
  
  public PageMargin(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PageMargin(DXW.PageMargin openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Top Margin Spacing
  /// </summary>
  [DataMember]
  public Int32? Top
  {
    get => _Element?.Top?.Value;
    set => _ExistingElement.Top = value;
  }
  
  
  /// <summary>
  ///   Right Margin Spacing
  /// </summary>
  [DataMember]
  public UInt32? Right
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   Page Bottom Spacing
  /// </summary>
  [DataMember]
  public Int32? Bottom
  {
    get => _Element?.Bottom?.Value;
    set => _ExistingElement.Bottom = value;
  }
  
  
  /// <summary>
  ///   Left Margin Spacing
  /// </summary>
  [DataMember]
  public UInt32? Left
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   Spacing to Top of Header
  /// </summary>
  [DataMember]
  public UInt32? Header
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   Spacing to Bottom of Footer
  /// </summary>
  [DataMember]
  public UInt32? Footer
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   Page Gutter Spacing
  /// </summary>
  [DataMember]
  public UInt32? Gutter
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
}
