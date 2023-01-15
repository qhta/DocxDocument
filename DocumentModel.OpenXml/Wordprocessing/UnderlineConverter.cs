using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using Underline = DocumentFormat.OpenXml.Wordprocessing.Underline;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the Underline Class.
/// </summary>
public static class UnderlineConverter
{
  /// <summary>
  ///   Underline Style
  /// </summary>
  public static UnderlineKind? GetVal(Underline? openXmlElement)
  {
    return EnumValueConverter.GetValue<UnderlineValues, UnderlineKind>(openXmlElement?.Val?.Value);
  }

  public static void SetVal(Underline? openXmlElement, UnderlineKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = EnumValueConverter.CreateEnumValue<UnderlineValues, UnderlineKind>(value);
  }

  /// <summary>
  ///   Underline Color
  /// </summary>
  public static String? GetColor(Underline? openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }

  public static void SetColor(Underline? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Color = new StringValue { Value = value };
      else
        openXmlElement.Color = null;
  }

  /// <summary>
  ///   Underline Theme Color
  /// </summary>
  public static ThemeColorKind? GetThemeColor(Underline? openXmlElement)
  {
    return EnumValueConverter.GetValue<ThemeColorValues, ThemeColorKind>(openXmlElement?.ThemeColor?.Value);
  }

  public static void SetThemeColor(Underline? openXmlElement, ThemeColorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ThemeColor = EnumValueConverter.CreateEnumValue<ThemeColorValues, ThemeColorKind>(value);
  }

  /// <summary>
  ///   Underline Theme Color Tint
  /// </summary>
  public static String? GetThemeTint(Underline? openXmlElement)
  {
    return openXmlElement?.ThemeTint?.Value;
  }

  public static void SetThemeTint(Underline? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ThemeTint = new StringValue { Value = value };
      else
        openXmlElement.ThemeTint = null;
  }

  /// <summary>
  ///   Underline Theme Color Shade
  /// </summary>
  public static String? GetThemeShade(Underline? openXmlElement)
  {
    return openXmlElement?.ThemeShade?.Value;
  }

  public static void SetThemeShade(Underline? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ThemeShade = new StringValue { Value = value };
      else
        openXmlElement.ThemeShade = null;
  }

  public static DocumentModel.Wordprocessing.Underline? CreateModelElement(Underline? openXmlElement)
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
    where OpenXmlElementType : Underline, new()
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