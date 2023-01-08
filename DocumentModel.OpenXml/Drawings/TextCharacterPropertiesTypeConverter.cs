namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the TextCharacterPropertiesType Class.
/// </summary>
public static class TextCharacterPropertiesTypeConverter
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public static Boolean? GetSmtClean(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSmtClean(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public static UInt32? GetSmtId(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSmtId(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// kumimoji
  /// </summary>
  public static Boolean? GetKumimoji(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetKumimoji(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// lang
  /// </summary>
  public static String? GetLanguage(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetLanguage(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// altLang
  /// </summary>
  public static String? GetAlternativeLanguage(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetAlternativeLanguage(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// sz
  /// </summary>
  public static Int32? GetFontSize(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFontSize(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// b
  /// </summary>
  public static Boolean? GetBold(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBold(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// i
  /// </summary>
  public static Boolean? GetItalic(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetItalic(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// u
  /// </summary>
  public static DocumentModel.Drawings.TextUnderlineKind? GetUnderline(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues, DocumentModel.Drawings.TextUnderlineKind>(openXmlElement?.Underline?.Value);
  }
  
  public static void SetUnderline(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.TextUnderlineKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Underline = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues, DocumentModel.Drawings.TextUnderlineKind>(value);
  }
  
  /// <summary>
  /// strike
  /// </summary>
  public static DocumentModel.Drawings.TextStrikeKind? GetStrike(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues, DocumentModel.Drawings.TextStrikeKind>(openXmlElement?.Strike?.Value);
  }
  
  public static void SetStrike(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.TextStrikeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Strike = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues, DocumentModel.Drawings.TextStrikeKind>(value);
  }
  
  /// <summary>
  /// kern
  /// </summary>
  public static Int32? GetKerning(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetKerning(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// cap
  /// </summary>
  public static DocumentModel.Drawings.TextCapsKind? GetCapital(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextCapsValues, DocumentModel.Drawings.TextCapsKind>(openXmlElement?.Capital?.Value);
  }
  
  public static void SetCapital(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.TextCapsKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Capital = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextCapsValues, DocumentModel.Drawings.TextCapsKind>(value);
  }
  
  /// <summary>
  /// spc
  /// </summary>
  public static Int32? GetSpacing(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSpacing(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// normalizeH
  /// </summary>
  public static Boolean? GetNormalizeHeight(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNormalizeHeight(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// baseline
  /// </summary>
  public static Int32? GetBaseline(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBaseline(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// noProof
  /// </summary>
  public static Boolean? GetNoProof(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNoProof(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// dirty
  /// </summary>
  public static Boolean? GetDirty(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDirty(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// err
  /// </summary>
  public static Boolean? GetSpellingError(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSpellingError(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// smtClean
  /// </summary>
  public static Boolean? GetSmartTagClean(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSmartTagClean(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// smtId
  /// </summary>
  public static UInt32? GetSmartTagId(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSmartTagId(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// bmk
  /// </summary>
  public static String? GetBookmark(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetBookmark(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public static DocumentModel.Drawings.Outline? GetOutline(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetOutline(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.Outline? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
