namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Defines the WebVideoProperty Class.
/// </summary>
public partial class WebVideoProperty: ModelElement<DXO13WD.WebVideoProperty>
{
  public WebVideoProperty(): base(){ }
  
  public WebVideoProperty(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WebVideoProperty(DXO13WD.WebVideoProperty openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   embeddedHtml, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? EmbeddedHtml
  {
    get => _Element?.EmbeddedHtml;
    set => _ExistingElement.EmbeddedHtml = value;
  }
  
  
  /// <summary>
  ///   h, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public UInt32? Height
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   w, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public UInt32? Width
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
}
