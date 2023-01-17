namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Underline Class.
/// </summary>
public static class UnderlineConverter
{
  /// <summary>
  /// Underline Style
  /// </summary>
  private static DocumentModel.Wordprocessing.UnderlineKind? GetVal(DocumentFormat.OpenXml.Wordprocessing.Underline openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.UnderlineValues, DocumentModel.Wordprocessing.UnderlineKind>(openXmlElement?.Val?.Value);
  }
  
  private static void SetVal(DocumentFormat.OpenXml.Wordprocessing.Underline openXmlElement, DocumentModel.Wordprocessing.UnderlineKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.UnderlineValues, DocumentModel.Wordprocessing.UnderlineKind>(value);
  }
  
  /// <summary>
  /// Underline Color
  /// </summary>
  private static String? GetColor(DocumentFormat.OpenXml.Wordprocessing.Underline openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }
  
  private static void SetColor(DocumentFormat.OpenXml.Wordprocessing.Underline openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color = new StringValue { Value = value };
    else
      openXmlElement.Color = null;
  }
  
  /// <summary>
  /// Underline Theme Color
  /// </summary>
  private static DocumentModel.Wordprocessing.ThemeColorKind? GetThemeColor(DocumentFormat.OpenXml.Wordprocessing.Underline openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DocumentModel.Wordprocessing.ThemeColorKind>(openXmlElement?.ThemeColor?.Value);
  }
  
  private static void SetThemeColor(DocumentFormat.OpenXml.Wordprocessing.Underline openXmlElement, DocumentModel.Wordprocessing.ThemeColorKind? value)
  {
    openXmlElement.ThemeColor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DocumentModel.Wordprocessing.ThemeColorKind>(value);
  }
  
  /// <summary>
  /// Underline Theme Color Tint
  /// </summary>
  private static String? GetThemeTint(DocumentFormat.OpenXml.Wordprocessing.Underline openXmlElement)
  {
    return openXmlElement?.ThemeTint?.Value;
  }
  
  private static void SetThemeTint(DocumentFormat.OpenXml.Wordprocessing.Underline openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeTint = new StringValue { Value = value };
    else
      openXmlElement.ThemeTint = null;
  }
  
  /// <summary>
  /// Underline Theme Color Shade
  /// </summary>
  private static String? GetThemeShade(DocumentFormat.OpenXml.Wordprocessing.Underline openXmlElement)
  {
    return openXmlElement?.ThemeShade?.Value;
  }
  
  private static void SetThemeShade(DocumentFormat.OpenXml.Wordprocessing.Underline openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeShade = new StringValue { Value = value };
    else
      openXmlElement.ThemeShade = null;
  }
  
  public static DocumentModel.Wordprocessing.Underline? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Underline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Underline();
      value.Val = GetVal(openXmlElement);
      value.Color = GetColor(openXmlElement);
      value.ThemeColor = GetThemeColor(openXmlElement);
      value.ThemeTint = GetThemeTint(openXmlElement);
      value.ThemeShade = GetThemeShade(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Underline? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Underline, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetColor(openXmlElement, value?.Color);
      SetThemeColor(openXmlElement, value?.ThemeColor);
      SetThemeTint(openXmlElement, value?.ThemeTint);
      SetThemeShade(openXmlElement, value?.ThemeShade);
      return openXmlElement;
    }
    return default;
  }
}
