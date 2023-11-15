namespace DocumentModel.Wordprocessing;


/// <summary>
///   Freeze Document Layout.
/// </summary>
public partial class ReadModeInkLockDown: ModelElement<DXW.ReadModeInkLockDown>
{
  public ReadModeInkLockDown(): base(){ }
  
  public ReadModeInkLockDown(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ReadModeInkLockDown(DXW.ReadModeInkLockDown openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Use Actual Pages, Not Virtual Pages
  /// </summary>
  [DataMember]
  public Boolean? UseActualPages
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Virtual Page Width
  /// </summary>
  [DataMember]
  public UInt32? Width
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   Virtual Page Height
  /// </summary>
  [DataMember]
  public UInt32? Height
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   Font Size Scaling
  /// </summary>
  [DataMember]
  public String? FontSize
  {
    get => _Element?.FontSize;
    set => _ExistingElement.FontSize = value;
  }
  
}
