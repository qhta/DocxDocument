namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of properties which determine the behavior and appearance of a phonetic guide within the document.
/// </summary>
public partial class RubyProperties: ModelElement<DXW.RubyProperties>
{
  public RubyProperties(): base(){ }
  
  public RubyProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RubyProperties(DXW.RubyProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Phonetic Guide Text Alignment.
  /// </summary>
  [DataMember]
  public DMW.RubyAlignKind? RubyAlign
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Phonetic Guide Text Font Size.
  /// </summary>
  [DataMember]
  public DMW.PhoneticGuideTextFontSize? PhoneticGuideTextFontSize
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.HpsMeasureType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.HpsMeasureType");
  }
  
  
  /// <summary>
  ///   Distance Between Phonetic Guide Text and Phonetic Guide Base Text.
  /// </summary>
  [DataMember]
  public Int16? PhoneticGuideRaise
  {
    get => _Element?.GetIntVal<Int16, DXW.PhoneticGuideRaise>();
    set => _ExistingElement.SetIntVal<Int16, DXW.PhoneticGuideRaise>(value);
  }
  
  
  /// <summary>
  ///   Phonetic Guide Base Text Font Size.
  /// </summary>
  [DataMember]
  public DMW.PhoneticGuideBaseTextSize? PhoneticGuideBaseTextSize
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.HpsMeasureType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.HpsMeasureType");
  }
  
  
  /// <summary>
  ///   Language ID for Phonetic Guide.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? LanguageId
  {
    get => _Element?.GetHexIntVal<DXW.LanguageId>();
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Invalidated Field Cache.
  /// </summary>
  [DataMember]
  public DMW.Dirty? Dirty
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
}
