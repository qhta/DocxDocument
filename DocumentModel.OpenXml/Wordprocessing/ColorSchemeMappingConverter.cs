namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Theme Color Mappings.
/// </summary>
public static class ColorSchemeMappingConverter
{
  /// <summary>
  /// Background 1 Theme Color Mapping
  /// </summary>
  public static DocumentModel.Wordprocessing.ColorSchemeIndexKind? GetBackground1(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(openXmlElement?.Background1?.Value);
  }
  
  public static void SetBackground1(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement, DocumentModel.Wordprocessing.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Background1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Text 1 Theme Color Mapping
  /// </summary>
  public static DocumentModel.Wordprocessing.ColorSchemeIndexKind? GetText1(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(openXmlElement?.Text1?.Value);
  }
  
  public static void SetText1(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement, DocumentModel.Wordprocessing.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Text1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Background 2 Theme Color Mapping
  /// </summary>
  public static DocumentModel.Wordprocessing.ColorSchemeIndexKind? GetBackground2(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(openXmlElement?.Background2?.Value);
  }
  
  public static void SetBackground2(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement, DocumentModel.Wordprocessing.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Background2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Text 2 Theme Color Mapping
  /// </summary>
  public static DocumentModel.Wordprocessing.ColorSchemeIndexKind? GetText2(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(openXmlElement?.Text2?.Value);
  }
  
  public static void SetText2(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement, DocumentModel.Wordprocessing.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Text2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 1 Theme Color Mapping
  /// </summary>
  public static DocumentModel.Wordprocessing.ColorSchemeIndexKind? GetAccent1(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(openXmlElement?.Accent1?.Value);
  }
  
  public static void SetAccent1(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement, DocumentModel.Wordprocessing.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 2 Theme Color Mapping
  /// </summary>
  public static DocumentModel.Wordprocessing.ColorSchemeIndexKind? GetAccent2(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(openXmlElement?.Accent2?.Value);
  }
  
  public static void SetAccent2(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement, DocumentModel.Wordprocessing.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent3 Theme Color Mapping
  /// </summary>
  public static DocumentModel.Wordprocessing.ColorSchemeIndexKind? GetAccent3(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(openXmlElement?.Accent3?.Value);
  }
  
  public static void SetAccent3(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement, DocumentModel.Wordprocessing.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent3 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent4 Theme Color Mapping
  /// </summary>
  public static DocumentModel.Wordprocessing.ColorSchemeIndexKind? GetAccent4(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(openXmlElement?.Accent4?.Value);
  }
  
  public static void SetAccent4(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement, DocumentModel.Wordprocessing.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent4 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent5 Theme Color Mapping
  /// </summary>
  public static DocumentModel.Wordprocessing.ColorSchemeIndexKind? GetAccent5(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(openXmlElement?.Accent5?.Value);
  }
  
  public static void SetAccent5(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement, DocumentModel.Wordprocessing.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent5 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent6 Theme Color Mapping
  /// </summary>
  public static DocumentModel.Wordprocessing.ColorSchemeIndexKind? GetAccent6(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(openXmlElement?.Accent6?.Value);
  }
  
  public static void SetAccent6(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement, DocumentModel.Wordprocessing.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent6 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Hyperlink Theme Color Mapping
  /// </summary>
  public static DocumentModel.Wordprocessing.ColorSchemeIndexKind? GetHyperlink(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(openXmlElement?.Hyperlink?.Value);
  }
  
  public static void SetHyperlink(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement, DocumentModel.Wordprocessing.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Hyperlink = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Followed Hyperlink Theme Color Mapping
  /// </summary>
  public static DocumentModel.Wordprocessing.ColorSchemeIndexKind? GetFollowedHyperlink(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(openXmlElement?.FollowedHyperlink?.Value);
  }
  
  public static void SetFollowedHyperlink(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? openXmlElement, DocumentModel.Wordprocessing.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.FollowedHyperlink = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DocumentModel.Wordprocessing.ColorSchemeIndexKind>(value);
  }
  
}
