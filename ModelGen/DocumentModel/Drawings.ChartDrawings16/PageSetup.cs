namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the PageSetup Class.
/// </summary>
public partial class PageSetup: ModelElement<DXO16DCD.PageSetup>
{
  public PageSetup(): base(){ }
  
  public PageSetup(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PageSetup(DXO16DCD.PageSetup openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   paperSize, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public UInt32? PaperSize
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   firstPageNumber, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public UInt32? FirstPageNumber
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   blackAndWhite, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? BlackAndWhite
  {
    get => _Element?.BlackAndWhite?.Value;
    set => _ExistingElement.BlackAndWhite = value;
  }
  
  
  /// <summary>
  ///   draft, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? Draft
  {
    get => _Element?.Draft?.Value;
    set => _ExistingElement.Draft = value;
  }
  
  
  /// <summary>
  ///   useFirstPageNumber, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? UseFirstPageNumber
  {
    get => _Element?.UseFirstPageNumber?.Value;
    set => _ExistingElement.UseFirstPageNumber = value;
  }
  
  
  /// <summary>
  ///   horizontalDpi, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Int32? HorizontalDpi
  {
    get => _Element?.HorizontalDpi?.Value;
    set => _ExistingElement.HorizontalDpi = value;
  }
  
  
  /// <summary>
  ///   verticalDpi, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Int32? VerticalDpi
  {
    get => _Element?.VerticalDpi?.Value;
    set => _ExistingElement.VerticalDpi = value;
  }
  
  
  /// <summary>
  ///   copies, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public UInt32? Copies
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
}
