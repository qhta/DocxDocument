namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the TextCharacterPropertiesType Class.
/// </summary>
public partial class TextCharacterPropertiesType: ModelElement<DXO13DCS.TextCharacterPropertiesType>
{
  public TextCharacterPropertiesType(): base(){ }
  
  public TextCharacterPropertiesType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextCharacterPropertiesType(DXO13DCS.TextCharacterPropertiesType openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public Boolean? SmtClean
  {
    get => _Element?.SmtClean?.Value;
    set => _ExistingElement.SmtClean = value;
  }
  
  [DataMember]
  public DocumentModel.HexInt? SmtId
  {
    get => HexIntConverter.GetValue(_Element?.SmtId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   kumimoji
  /// </summary>
  [DataMember]
  public Boolean? Kumimoji
  {
    get => _Element?.Kumimoji?.Value;
    set => _ExistingElement.Kumimoji = value;
  }
  
  
  /// <summary>
  ///   lang
  /// </summary>
  [DataMember]
  public String? Language
  {
    get => _Element?.Language;
    set => _ExistingElement.Language = value;
  }
  
  
  /// <summary>
  ///   altLang
  /// </summary>
  [DataMember]
  public String? AlternativeLanguage
  {
    get => _Element?.AlternativeLanguage;
    set => _ExistingElement.AlternativeLanguage = value;
  }
  
  
  /// <summary>
  ///   sz
  /// </summary>
  [DataMember]
  public Int32? FontSize
  {
    get => _Element?.FontSize?.Value;
    set => _ExistingElement.FontSize = value;
  }
  
  
  /// <summary>
  ///   b
  /// </summary>
  [DataMember]
  public Boolean? Bold
  {
    get => _Element?.Bold?.Value;
    set => _ExistingElement.Bold = value;
  }
  
  
  /// <summary>
  ///   i
  /// </summary>
  [DataMember]
  public Boolean? Italic
  {
    get => _Element?.Italic?.Value;
    set => _ExistingElement.Italic = value;
  }
  
  
  /// <summary>
  ///   kern
  /// </summary>
  [DataMember]
  public Int32? Kerning
  {
    get => _Element?.Kerning?.Value;
    set => _ExistingElement.Kerning = value;
  }
  
  
  /// <summary>
  ///   spc
  /// </summary>
  [DataMember]
  public Int32? Spacing
  {
    get => _Element?.Spacing?.Value;
    set => _ExistingElement.Spacing = value;
  }
  
  
  /// <summary>
  ///   normalizeH
  /// </summary>
  [DataMember]
  public Boolean? NormalizeHeight
  {
    get => _Element?.NormalizeHeight?.Value;
    set => _ExistingElement.NormalizeHeight = value;
  }
  
  
  /// <summary>
  ///   baseline
  /// </summary>
  [DataMember]
  public Int32? Baseline
  {
    get => _Element?.Baseline?.Value;
    set => _ExistingElement.Baseline = value;
  }
  
  
  /// <summary>
  ///   noProof
  /// </summary>
  [DataMember]
  public Boolean? NoProof
  {
    get => _Element?.NoProof?.Value;
    set => _ExistingElement.NoProof = value;
  }
  
  
  /// <summary>
  ///   dirty
  /// </summary>
  [DataMember]
  public Boolean? Dirty
  {
    get => _Element?.Dirty?.Value;
    set => _ExistingElement.Dirty = value;
  }
  
  
  /// <summary>
  ///   err
  /// </summary>
  [DataMember]
  public Boolean? SpellingError
  {
    get => _Element?.SpellingError?.Value;
    set => _ExistingElement.SpellingError = value;
  }
  
  
  /// <summary>
  ///   smtClean
  /// </summary>
  [DataMember]
  public Boolean? SmartTagClean
  {
    get => _Element?.SmartTagClean?.Value;
    set => _ExistingElement.SmartTagClean = value;
  }
  
  
  /// <summary>
  ///   smtId
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? SmartTagId
  {
    get => HexIntConverter.GetValue(_Element?.SmartTagId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   bmk
  /// </summary>
  [DataMember]
  public String? Bookmark
  {
    get => _Element?.Bookmark;
    set => _ExistingElement.Bookmark = value;
  }
  
  
  /// <summary>
  ///   Outline.
  /// </summary>
  [DataMember]
  public DMD.Outline? Outline
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.LinePropertiesType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.LinePropertiesType");
  }
  
  [DataMember]
  public DMD.NoFill? NoFill
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  [DataMember]
  public DMD.SolidFill? SolidFill
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMD.GradientFill? GradientFill
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMD.BlipFill? BlipFill
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMD.PatternFill? PatternFill
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMD.GroupFill? GroupFill
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  [DataMember]
  public DMD.EffectList? EffectList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMD.EffectDag? EffectDag
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.EffectContainerType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.EffectContainerType");
  }
  
  [DataMember]
  public DMD.Highlight? Highlight
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ColorType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ColorType");
  }
  
  [DataMember]
  public DMD.UnderlineFollowsText? UnderlineFollowsText
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  [DataMember]
  public DMD.UnderlineFillText? UnderlineFillText
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  [DataMember]
  public DMD.UnderlineFill? UnderlineFill
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMD.LatinFont? LatinFont
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextFontType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextFontType");
  }
  
  [DataMember]
  public DMD.EastAsianFont? EastAsianFont
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextFontType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextFontType");
  }
  
  [DataMember]
  public DMD.ComplexScriptFont? ComplexScriptFont
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextFontType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextFontType");
  }
  
  [DataMember]
  public DMD.SymbolFont? SymbolFont
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextFontType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextFontType");
  }
  
  [DataMember]
  public DMD.HyperlinkOnClick? HyperlinkOnClick
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.HyperlinkType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.HyperlinkType");
  }
  
  [DataMember]
  public DMD.HyperlinkOnMouseOver? HyperlinkOnMouseOver
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.HyperlinkType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.HyperlinkType");
  }
  
  [DataMember]
  public Boolean? RightToLeft
  {
    get => _Element?.GetBoolVal<DXD.RightToLeft>();
    set => _ExistingElement.SetBoolVal<DXD.RightToLeft>(value);
  }
  
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
