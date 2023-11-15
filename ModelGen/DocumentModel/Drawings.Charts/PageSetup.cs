namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Page Setup.
/// </summary>
public partial class PageSetup: ModelElement<DXDC.PageSetup>
{
  public PageSetup(): base(){ }
  
  public PageSetup(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PageSetup(DXDC.PageSetup openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Page Size
  /// </summary>
  [DataMember]
  public UInt32? PaperSize
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   First Page Number
  /// </summary>
  [DataMember]
  public Int32? FirstPageNumber
  {
    get => _Element?.FirstPageNumber?.Value;
    set => _ExistingElement.FirstPageNumber = value;
  }
  
  
  /// <summary>
  ///   Black and White
  /// </summary>
  [DataMember]
  public Boolean? BlackAndWhite
  {
    get => _Element?.BlackAndWhite?.Value;
    set => _ExistingElement.BlackAndWhite = value;
  }
  
  
  /// <summary>
  ///   Draft
  /// </summary>
  [DataMember]
  public Boolean? Draft
  {
    get => _Element?.Draft?.Value;
    set => _ExistingElement.Draft = value;
  }
  
  
  /// <summary>
  ///   Use First Page Number
  /// </summary>
  [DataMember]
  public Boolean? UseFirstPageNumber
  {
    get => _Element?.UseFirstPageNumber?.Value;
    set => _ExistingElement.UseFirstPageNumber = value;
  }
  
  
  /// <summary>
  ///   Horizontal DPI
  /// </summary>
  [DataMember]
  public Int32? HorizontalDpi
  {
    get => _Element?.HorizontalDpi?.Value;
    set => _ExistingElement.HorizontalDpi = value;
  }
  
  
  /// <summary>
  ///   Vertical DPI
  /// </summary>
  [DataMember]
  public Int32? VerticalDpi
  {
    get => _Element?.VerticalDpi?.Value;
    set => _ExistingElement.VerticalDpi = value;
  }
  
  
  /// <summary>
  ///   Copies
  /// </summary>
  [DataMember]
  public UInt32? Copies
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
}
