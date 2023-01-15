using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using Color = DocumentFormat.OpenXml.Office2013.Word.Color;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the Color Class.
/// </summary>
public static class Color3Converter
{
  /// <summary>
  ///   Run Content Color
  /// </summary>
  public static String? GetVal(Color? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(Color? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }

  /// <summary>
  ///   Run Content Theme Color
  /// </summary>
  public static ThemeColorKind? GetThemeColor(Color? openXmlElement)
  {
    return EnumValueConverter.GetValue<ThemeColorValues, ThemeColorKind>(openXmlElement?.ThemeColor?.Value);
  }

  public static void SetThemeColor(Color? openXmlElement, ThemeColorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ThemeColor = EnumValueConverter.CreateEnumValue<ThemeColorValues, ThemeColorKind>(value);
  }

  /// <summary>
  ///   Run Content Theme Color Tint
  /// </summary>
  public static String? GetThemeTint(Color? openXmlElement)
  {
    return openXmlElement?.ThemeTint?.Value;
  }

  public static void SetThemeTint(Color? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ThemeTint = new StringValue { Value = value };
      else
        openXmlElement.ThemeTint = null;
  }

  /// <summary>
  ///   Run Content Theme Color Shade
  /// </summary>
  public static String? GetThemeShade(Color? openXmlElement)
  {
    return openXmlElement?.ThemeShade?.Value;
  }

  public static void SetThemeShade(Color? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ThemeShade = new StringValue { Value = value };
      else
        openXmlElement.ThemeShade = null;
  }

  public static Color3? CreateModelElement(Color? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new Color3();
      value.Val = GetVal(openXmlElement);
      value.ThemeColor = GetThemeColor(openXmlElement);
      value.ThemeTint = GetThemeTint(openXmlElement);
      value.ThemeShade = GetThemeShade(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(Color3? value)
    where OpenXmlElementType : Color, new()
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