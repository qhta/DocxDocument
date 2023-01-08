namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the TextCharacterPropertiesType Class.
/// </summary>
public static class TextCharacterPropertiesTypeConverter
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public static Boolean? GetSmtClean(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSmtClean(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public static UInt32? GetSmtId(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSmtId(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// kumimoji
  /// </summary>
  public static Boolean? GetKumimoji(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetKumimoji(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// lang
  /// </summary>
  public static String? GetLanguage(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetLanguage(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// altLang
  /// </summary>
  public static String? GetAlternativeLanguage(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetAlternativeLanguage(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// sz
  /// </summary>
  public static Int32? GetFontSize(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFontSize(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// b
  /// </summary>
  public static Boolean? GetBold(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBold(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// i
  /// </summary>
  public static Boolean? GetItalic(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetItalic(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// u
  /// </summary>
  public static DocumentModel.Drawings.TextUnderlineKind? GetUnderline(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues, DocumentModel.Drawings.TextUnderlineKind>(openXmlElement?.Underline?.Value);
  }
  
  public static void SetUnderline(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.TextUnderlineKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Underline = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues, DocumentModel.Drawings.TextUnderlineKind>(value);
  }
  
  /// <summary>
  /// strike
  /// </summary>
  public static DocumentModel.Drawings.TextStrikeKind? GetStrike(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues, DocumentModel.Drawings.TextStrikeKind>(openXmlElement?.Strike?.Value);
  }
  
  public static void SetStrike(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.TextStrikeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Strike = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues, DocumentModel.Drawings.TextStrikeKind>(value);
  }
  
  /// <summary>
  /// kern
  /// </summary>
  public static Int32? GetKerning(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetKerning(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// cap
  /// </summary>
  public static DocumentModel.Drawings.TextCapsKind? GetCapital(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextCapsValues, DocumentModel.Drawings.TextCapsKind>(openXmlElement?.Capital?.Value);
  }
  
  public static void SetCapital(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.TextCapsKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Capital = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextCapsValues, DocumentModel.Drawings.TextCapsKind>(value);
  }
  
  /// <summary>
  /// spc
  /// </summary>
  public static Int32? GetSpacing(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSpacing(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// normalizeH
  /// </summary>
  public static Boolean? GetNormalizeHeight(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNormalizeHeight(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// baseline
  /// </summary>
  public static Int32? GetBaseline(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBaseline(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// noProof
  /// </summary>
  public static Boolean? GetNoProof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNoProof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// dirty
  /// </summary>
  public static Boolean? GetDirty(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDirty(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// err
  /// </summary>
  public static Boolean? GetSpellingError(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSpellingError(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// smtClean
  /// </summary>
  public static Boolean? GetSmartTagClean(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSmartTagClean(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// smtId
  /// </summary>
  public static UInt32? GetSmartTagId(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSmartTagId(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// bmk
  /// </summary>
  public static String? GetBookmark(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetBookmark(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public static DocumentModel.Drawings.Outline? GetOutline(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetOutline(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.Outline? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetNoFill(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNoFill(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.SolidFill? GetSolidFill(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSolidFill(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.SolidFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.GradientFill? GetGradientFill(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGradientFill(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.GradientFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.BlipFill? GetBlipFill(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBlipFill(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.BlipFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.PatternFill? GetPatternFill(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPatternFill(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.PatternFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetGroupFill(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGroupFill(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.EffectList? GetEffectList(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEffectList(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.EffectList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.EffectDag? GetEffectDag(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEffectDag(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.EffectDag? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Highlight? GetHighlight(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHighlight(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.Highlight? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetUnderlineFollowsText(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetUnderlineFollowsText(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetUnderlineFillText(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetUnderlineFillText(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.UnderlineFill? GetUnderlineFill(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetUnderlineFill(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.UnderlineFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.TextFontType? GetLatinFont(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLatinFont(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.TextFontType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.TextFontType? GetEastAsianFont(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEastAsianFont(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.TextFontType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.TextFontType? GetComplexScriptFont(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetComplexScriptFont(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.TextFontType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.TextFontType? GetSymbolFont(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSymbolFont(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.TextFontType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.HyperlinkOnClick? GetHyperlinkOnClick(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHyperlinkOnClick(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.HyperlinkOnClick? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.HyperlinkOnMouseOver? GetHyperlinkOnMouseOver(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHyperlinkOnMouseOver(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.HyperlinkOnMouseOver? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetRightToLeft(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRightToLeft(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
