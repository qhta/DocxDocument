using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using Shading = DocumentFormat.OpenXml.Wordprocessing.Shading;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the Shading Class.
/// </summary>
public static class ShadingConverter
{
  /// <summary>
  ///   Shading Pattern
  /// </summary>
  public static ShadingPatternKind? GetVal(Shading? openXmlElement)
  {
    return EnumValueConverter.GetValue<ShadingPatternValues, ShadingPatternKind>(openXmlElement?.Val?.Value);
  }

  public static void SetVal(Shading? openXmlElement, ShadingPatternKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = EnumValueConverter.CreateEnumValue<ShadingPatternValues, ShadingPatternKind>(value);
  }

  /// <summary>
  ///   Shading Pattern Color
  /// </summary>
  public static String? GetColor(Shading? openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }

  public static void SetColor(Shading? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Color = new StringValue { Value = value };
      else
        openXmlElement.Color = null;
  }

  /// <summary>
  ///   Shading Pattern Theme Color
  /// </summary>
  public static ThemeColorKind? GetThemeColor(Shading? openXmlElement)
  {
    return EnumValueConverter.GetValue<ThemeColorValues, ThemeColorKind>(openXmlElement?.ThemeColor?.Value);
  }

  public static void SetThemeColor(Shading? openXmlElement, ThemeColorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ThemeColor = EnumValueConverter.CreateEnumValue<ThemeColorValues, ThemeColorKind>(value);
  }

  /// <summary>
  ///   Shading Pattern Theme Color Tint
  /// </summary>
  public static String? GetThemeTint(Shading? openXmlElement)
  {
    return openXmlElement?.ThemeTint?.Value;
  }

  public static void SetThemeTint(Shading? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ThemeTint = new StringValue { Value = value };
      else
        openXmlElement.ThemeTint = null;
  }

  /// <summary>
  ///   Shading Pattern Theme Color Shade
  /// </summary>
  public static String? GetThemeShade(Shading? openXmlElement)
  {
    return openXmlElement?.ThemeShade?.Value;
  }

  public static void SetThemeShade(Shading? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ThemeShade = new StringValue { Value = value };
      else
        openXmlElement.ThemeShade = null;
  }

  /// <summary>
  ///   Shading Background Color
  /// </summary>
  public static String? GetFill(Shading? openXmlElement)
  {
    return openXmlElement?.Fill?.Value;
  }

  public static void SetFill(Shading? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Fill = new StringValue { Value = value };
      else
        openXmlElement.Fill = null;
  }

  /// <summary>
  ///   Shading Background Theme Color
  /// </summary>
  public static ThemeColorKind? GetThemeFill(Shading? openXmlElement)
  {
    return EnumValueConverter.GetValue<ThemeColorValues, ThemeColorKind>(openXmlElement?.ThemeFill?.Value);
  }

  public static void SetThemeFill(Shading? openXmlElement, ThemeColorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ThemeFill = EnumValueConverter.CreateEnumValue<ThemeColorValues, ThemeColorKind>(value);
  }

  /// <summary>
  ///   Shading Background Theme Color Tint
  /// </summary>
  public static String? GetThemeFillTint(Shading? openXmlElement)
  {
    return openXmlElement?.ThemeFillTint?.Value;
  }

  public static void SetThemeFillTint(Shading? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ThemeFillTint = new StringValue { Value = value };
      else
        openXmlElement.ThemeFillTint = null;
  }

  /// <summary>
  ///   Shading Background Theme Color Shade
  /// </summary>
  public static String? GetThemeFillShade(Shading? openXmlElement)
  {
    return openXmlElement?.ThemeFillShade?.Value;
  }

  public static void SetThemeFillShade(Shading? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ThemeFillShade = new StringValue { Value = value };
      else
        openXmlElement.ThemeFillShade = null;
  }

  public static DocumentModel.Wordprocessing.Shading? CreateModelElement(Shading? openXmlElement)
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
    where OpenXmlElementType : Shading, new()
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