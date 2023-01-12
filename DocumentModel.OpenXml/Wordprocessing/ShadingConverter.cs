namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Shading Class.
/// </summary>
public static class ShadingConverter
{
  /// <summary>
  /// Shading Pattern
  /// </summary>
  public static DocumentModel.Wordprocessing.ShadingPatternKind? GetVal(DocumentFormat.OpenXml.Wordprocessing.Shading? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues, DocumentModel.Wordprocessing.ShadingPatternKind>(openXmlElement?.Val?.Value);
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Wordprocessing.Shading? openXmlElement, DocumentModel.Wordprocessing.ShadingPatternKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues, DocumentModel.Wordprocessing.ShadingPatternKind>(value);
  }
  
  /// <summary>
  /// Shading Pattern Color
  /// </summary>
  public static String? GetColor(DocumentFormat.OpenXml.Wordprocessing.Shading? openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }
  
  public static void SetColor(DocumentFormat.OpenXml.Wordprocessing.Shading? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Color = new StringValue { Value = value };
      else
        openXmlElement.Color = null;
  }
  
  /// <summary>
  /// Shading Pattern Theme Color
  /// </summary>
  public static DocumentModel.Wordprocessing.ThemeColorKind? GetThemeColor(DocumentFormat.OpenXml.Wordprocessing.Shading? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DocumentModel.Wordprocessing.ThemeColorKind>(openXmlElement?.ThemeColor?.Value);
  }
  
  public static void SetThemeColor(DocumentFormat.OpenXml.Wordprocessing.Shading? openXmlElement, DocumentModel.Wordprocessing.ThemeColorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ThemeColor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DocumentModel.Wordprocessing.ThemeColorKind>(value);
  }
  
  /// <summary>
  /// Shading Pattern Theme Color Tint
  /// </summary>
  public static String? GetThemeTint(DocumentFormat.OpenXml.Wordprocessing.Shading? openXmlElement)
  {
    return openXmlElement?.ThemeTint?.Value;
  }
  
  public static void SetThemeTint(DocumentFormat.OpenXml.Wordprocessing.Shading? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ThemeTint = new StringValue { Value = value };
      else
        openXmlElement.ThemeTint = null;
  }
  
  /// <summary>
  /// Shading Pattern Theme Color Shade
  /// </summary>
  public static String? GetThemeShade(DocumentFormat.OpenXml.Wordprocessing.Shading? openXmlElement)
  {
    return openXmlElement?.ThemeShade?.Value;
  }
  
  public static void SetThemeShade(DocumentFormat.OpenXml.Wordprocessing.Shading? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ThemeShade = new StringValue { Value = value };
      else
        openXmlElement.ThemeShade = null;
  }
  
  /// <summary>
  /// Shading Background Color
  /// </summary>
  public static String? GetFill(DocumentFormat.OpenXml.Wordprocessing.Shading? openXmlElement)
  {
    return openXmlElement?.Fill?.Value;
  }
  
  public static void SetFill(DocumentFormat.OpenXml.Wordprocessing.Shading? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Fill = new StringValue { Value = value };
      else
        openXmlElement.Fill = null;
  }
  
  /// <summary>
  /// Shading Background Theme Color
  /// </summary>
  public static DocumentModel.Wordprocessing.ThemeColorKind? GetThemeFill(DocumentFormat.OpenXml.Wordprocessing.Shading? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DocumentModel.Wordprocessing.ThemeColorKind>(openXmlElement?.ThemeFill?.Value);
  }
  
  public static void SetThemeFill(DocumentFormat.OpenXml.Wordprocessing.Shading? openXmlElement, DocumentModel.Wordprocessing.ThemeColorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ThemeFill = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DocumentModel.Wordprocessing.ThemeColorKind>(value);
  }
  
  /// <summary>
  /// Shading Background Theme Color Tint
  /// </summary>
  public static String? GetThemeFillTint(DocumentFormat.OpenXml.Wordprocessing.Shading? openXmlElement)
  {
    return openXmlElement?.ThemeFillTint?.Value;
  }
  
  public static void SetThemeFillTint(DocumentFormat.OpenXml.Wordprocessing.Shading? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ThemeFillTint = new StringValue { Value = value };
      else
        openXmlElement.ThemeFillTint = null;
  }
  
  /// <summary>
  /// Shading Background Theme Color Shade
  /// </summary>
  public static String? GetThemeFillShade(DocumentFormat.OpenXml.Wordprocessing.Shading? openXmlElement)
  {
    return openXmlElement?.ThemeFillShade?.Value;
  }
  
  public static void SetThemeFillShade(DocumentFormat.OpenXml.Wordprocessing.Shading? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ThemeFillShade = new StringValue { Value = value };
      else
        openXmlElement.ThemeFillShade = null;
  }
  
  public static DocumentModel.Wordprocessing.Shading? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Shading? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Shading();
      value.Val = GetVal(openXmlElement);
      value.Color = GetColor(openXmlElement);
      value.ThemeColor = GetThemeColor(openXmlElement);
      value.ThemeTint = GetThemeTint(openXmlElement);
      value.ThemeShade = GetThemeShade(openXmlElement);
      value.Fill = GetFill(openXmlElement);
      value.ThemeFill = GetThemeFill(openXmlElement);
      value.ThemeFillTint = GetThemeFillTint(openXmlElement);
      value.ThemeFillShade = GetThemeFillShade(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Shading? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Shading, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetColor(openXmlElement, value?.Color);
      SetThemeColor(openXmlElement, value?.ThemeColor);
      SetThemeTint(openXmlElement, value?.ThemeTint);
      SetThemeShade(openXmlElement, value?.ThemeShade);
      SetFill(openXmlElement, value?.Fill);
      SetThemeFill(openXmlElement, value?.ThemeFill);
      SetThemeFillTint(openXmlElement, value?.ThemeFillTint);
      SetThemeFillShade(openXmlElement, value?.ThemeFillShade);
      return openXmlElement;
    }
    return default;
  }
}
