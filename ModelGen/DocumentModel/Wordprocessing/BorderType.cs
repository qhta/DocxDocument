namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the BorderType Class.
/// </summary>
public partial class BorderType: ModelElement<DXW.BorderType>
{
  public BorderType(): base(){ }
  
  public BorderType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BorderType(DXW.BorderType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Border Color
  /// </summary>
  [DataMember]
  public String? Color
  {
    get => _Element?.Color;
    set => _ExistingElement.Color = value;
  }
  
  
  /// <summary>
  ///   Border Theme Color Tint
  /// </summary>
  [DataMember]
  public String? ThemeTint
  {
    get => _Element?.ThemeTint;
    set => _ExistingElement.ThemeTint = value;
  }
  
  
  /// <summary>
  ///   Border Theme Color Shade
  /// </summary>
  [DataMember]
  public String? ThemeShade
  {
    get => _Element?.ThemeShade;
    set => _ExistingElement.ThemeShade = value;
  }
  
  
  /// <summary>
  ///   Border Width
  /// </summary>
  [DataMember]
  public UInt32? Size
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   Border Spacing Measurement
  /// </summary>
  [DataMember]
  public UInt32? Space
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   Border Shadow
  /// </summary>
  [DataMember]
  public Boolean? Shadow
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Create Frame Effect
  /// </summary>
  [DataMember]
  public Boolean? Frame
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
}
