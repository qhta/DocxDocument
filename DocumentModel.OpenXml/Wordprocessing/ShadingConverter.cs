namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Shading Class.
/// </summary>
public static class ShadingConverter
{
  /// <summary>
  /// Shading Pattern
  /// </summary>
  private static DMW.ShadingPatternKind? GetVal(DXW.Shading openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues, DMW.ShadingPatternKind>(openXmlElement?.Val?.Value);
  }
  
  private static void SetVal(DXW.Shading openXmlElement, DMW.ShadingPatternKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues, DMW.ShadingPatternKind>(value);
  }
  
  /// <summary>
  /// Shading Pattern Color
  /// </summary>
  private static String? GetColor(DXW.Shading openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }
  
  private static void SetColor(DXW.Shading openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color = new StringValue { Value = value };
    else
      openXmlElement.Color = null;
  }
  
  /// <summary>
  /// Shading Pattern Theme Color
  /// </summary>
  private static DMW.ThemeColorKind? GetThemeColor(DXW.Shading openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(openXmlElement?.ThemeColor?.Value);
  }
  
  private static void SetThemeColor(DXW.Shading openXmlElement, DMW.ThemeColorKind? value)
  {
    openXmlElement.ThemeColor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(value);
  }
  
  /// <summary>
  /// Shading Pattern Theme Color Tint
  /// </summary>
  private static String? GetThemeTint(DXW.Shading openXmlElement)
  {
    return openXmlElement?.ThemeTint?.Value;
  }
  
  private static void SetThemeTint(DXW.Shading openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeTint = new StringValue { Value = value };
    else
      openXmlElement.ThemeTint = null;
  }
  
  /// <summary>
  /// Shading Pattern Theme Color Shade
  /// </summary>
  private static String? GetThemeShade(DXW.Shading openXmlElement)
  {
    return openXmlElement?.ThemeShade?.Value;
  }
  
  private static void SetThemeShade(DXW.Shading openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeShade = new StringValue { Value = value };
    else
      openXmlElement.ThemeShade = null;
  }
  
  /// <summary>
  /// Shading Background Color
  /// </summary>
  private static String? GetFill(DXW.Shading openXmlElement)
  {
    return openXmlElement?.Fill?.Value;
  }
  
  private static void SetFill(DXW.Shading openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Fill = new StringValue { Value = value };
    else
      openXmlElement.Fill = null;
  }
  
  /// <summary>
  /// Shading Background Theme Color
  /// </summary>
  private static DMW.ThemeColorKind? GetThemeFill(DXW.Shading openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(openXmlElement?.ThemeFill?.Value);
  }
  
  private static void SetThemeFill(DXW.Shading openXmlElement, DMW.ThemeColorKind? value)
  {
    openXmlElement.ThemeFill = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(value);
  }
  
  /// <summary>
  /// Shading Background Theme Color Tint
  /// </summary>
  private static String? GetThemeFillTint(DXW.Shading openXmlElement)
  {
    return openXmlElement?.ThemeFillTint?.Value;
  }
  
  private static void SetThemeFillTint(DXW.Shading openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeFillTint = new StringValue { Value = value };
    else
      openXmlElement.ThemeFillTint = null;
  }
  
  /// <summary>
  /// Shading Background Theme Color Shade
  /// </summary>
  private static String? GetThemeFillShade(DXW.Shading openXmlElement)
  {
    return openXmlElement?.ThemeFillShade?.Value;
  }
  
  private static void SetThemeFillShade(DXW.Shading openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeFillShade = new StringValue { Value = value };
    else
      openXmlElement.ThemeFillShade = null;
  }
  
  public static DMW.Shading? CreateModelElement(DXW.Shading? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Shading();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Shading? value)
    where OpenXmlElementType: DXW.Shading, new()
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
