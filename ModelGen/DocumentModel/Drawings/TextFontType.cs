namespace DocumentModel.Drawings;


/// <summary>
///   Defines the TextFontType Class.
/// </summary>
public partial class TextFontType: ModelElement<DXD.TextFontType>
{
  public TextFontType(): base(){ }
  
  public TextFontType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextFontType(DXD.TextFontType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Text Typeface
  /// </summary>
  [DataMember]
  public String? Typeface
  {
    get => _Element?.Typeface;
    set => _ExistingElement.Typeface = value;
  }
  
  
  /// <summary>
  ///   Panose Setting
  /// </summary>
  [DataMember]
  public DM.HexBinary? Panose
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.Object");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.Object");
  }
  
  
  /// <summary>
  ///   Similar Font Family
  /// </summary>
  [DataMember]
  public SByte? PitchFamily
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.SByte]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.SByte]");
  }
  
  
  /// <summary>
  ///   Similar Character Set
  /// </summary>
  [DataMember]
  public SByte? CharacterSet
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.SByte]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.SByte]");
  }
  
}
