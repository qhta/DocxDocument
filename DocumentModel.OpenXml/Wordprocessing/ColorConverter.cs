namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Color Class.
/// </summary>
public static class ColorConverter
{
  /// <summary>
  /// Run Content Color
  /// </summary>
  private static String? GetVal(DocumentFormat.OpenXml.Wordprocessing.Color openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static void SetVal(DocumentFormat.OpenXml.Wordprocessing.Color openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  /// <summary>
  /// Run Content Theme Color
  /// </summary>
  private static DocumentModel.Wordprocessing.ThemeColorKind? GetThemeColor(DocumentFormat.OpenXml.Wordprocessing.Color openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DocumentModel.Wordprocessing.ThemeColorKind>(openXmlElement?.ThemeColor?.Value);
  }
  
  private static void SetThemeColor(DocumentFormat.OpenXml.Wordprocessing.Color openXmlElement, DocumentModel.Wordprocessing.ThemeColorKind? value)
  {
    openXmlElement.ThemeColor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DocumentModel.Wordprocessing.ThemeColorKind>(value);
  }
  
  /// <summary>
  /// Run Content Theme Color Tint
  /// </summary>
  private static String? GetThemeTint(DocumentFormat.OpenXml.Wordprocessing.Color openXmlElement)
  {
    return openXmlElement?.ThemeTint?.Value;
  }
  
  private static void SetThemeTint(DocumentFormat.OpenXml.Wordprocessing.Color openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeTint = new StringValue { Value = value };
    else
      openXmlElement.ThemeTint = null;
  }
  
  /// <summary>
  /// Run Content Theme Color Shade
  /// </summary>
  private static String? GetThemeShade(DocumentFormat.OpenXml.Wordprocessing.Color openXmlElement)
  {
    return openXmlElement?.ThemeShade?.Value;
  }
  
  private static void SetThemeShade(DocumentFormat.OpenXml.Wordprocessing.Color openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeShade = new StringValue { Value = value };
    else
      openXmlElement.ThemeShade = null;
  }
  
  public static DocumentModel.Wordprocessing.Color? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Color? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Color();
      value.Val = GetVal(openXmlElement);
      value.ThemeColor = GetThemeColor(openXmlElement);
      value.ThemeTint = GetThemeTint(openXmlElement);
      value.ThemeShade = GetThemeShade(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Color? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Color, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetThemeColor(openXmlElement, value?.ThemeColor);
      SetThemeTint(openXmlElement, value?.ThemeTint);
      SetThemeShade(openXmlElement, value?.ThemeShade);
      return openXmlElement;
    }
    return default;
  }
}
