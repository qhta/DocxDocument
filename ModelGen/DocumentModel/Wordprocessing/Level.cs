namespace DocumentModel.Wordprocessing;


/// <summary>
///   Numbering Level Definition.
/// </summary>
public partial class Level: ModelElement<DXW.Level>
{
  public Level(): base(){ }
  
  public Level(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Level(DXW.Level openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Numbering Level
  /// </summary>
  [DataMember]
  public Int32? LevelIndex
  {
    get => _Element?.LevelIndex?.Value;
    set => _ExistingElement.LevelIndex = value;
  }
  
  
  /// <summary>
  ///   Template Code
  /// </summary>
  [DataMember]
  public DM.HexBinary? TemplateCode
  {
    get => HexIntConverter.GetValue(_Element?.TemplateCode);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Tentative Numbering
  /// </summary>
  [DataMember]
  public Boolean? Tentative
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Starting Value.
  /// </summary>
  [DataMember]
  public DMW.StartNumberingValue? StartNumberingValue
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.NonNegativeDecimalNumberType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.NonNegativeDecimalNumberType");
  }
  
  
  /// <summary>
  ///   Numbering Format.
  /// </summary>
  [DataMember]
  public DMW.NumberingFormat? NumberingFormat
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Restart Numbering Level Symbol.
  /// </summary>
  [DataMember]
  public DMW.LevelRestart? LevelRestart
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.DecimalNumberType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.DecimalNumberType");
  }
  
  
  /// <summary>
  ///   Paragraph Style's Associated Numbering Level.
  /// </summary>
  [DataMember]
  public DMW.ParagraphStyleIdInLevel? ParagraphStyleIdInLevel
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.String253Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.String253Type");
  }
  
  
  /// <summary>
  ///   Display All Levels Using Arabic Numerals.
  /// </summary>
  [DataMember]
  public DMW.IsLegalNumberingStyle? IsLegalNumberingStyle
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Content Between Numbering Symbol and Paragraph Text.
  /// </summary>
  [DataMember]
  public DMW.LevelSuffixKind? LevelSuffix
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Numbering Level Text.
  /// </summary>
  [DataMember]
  public DMW.LevelText? LevelText
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Picture Numbering Symbol Definition Reference.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? LevelPictureBulletId
  {
    get => _Element?.GetHexIntVal<DXW.LevelPictureBulletId>();
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Legacy Numbering Level Properties.
  /// </summary>
  [DataMember]
  public DMW.LegacyNumbering? LegacyNumbering
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Justification.
  /// </summary>
  [DataMember]
  public DMW.LevelJustificationKind? LevelJustification
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Numbering Level Associated Paragraph Properties.
  /// </summary>
  [DataMember]
  public DMW.PreviousParagraphProperties? PreviousParagraphProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Numbering Symbol Run Properties.
  /// </summary>
  [DataMember]
  public DMW.NumberingSymbolRunProperties? NumberingSymbolRunProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
