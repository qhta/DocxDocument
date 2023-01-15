using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using BorderType = DocumentFormat.OpenXml.Wordprocessing.BorderType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the BorderType Class.
/// </summary>
public static class BorderTypeConverter
{
  /// <summary>
  ///   Border Style
  /// </summary>
  public static BorderKind? GetVal(BorderType? openXmlElement)
  {
    return EnumValueConverter.GetValue<BorderValues, BorderKind>(openXmlElement?.Val?.Value);
  }

  public static void SetVal(BorderType? openXmlElement, BorderKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = EnumValueConverter.CreateEnumValue<BorderValues, BorderKind>(value);
  }

  /// <summary>
  ///   Border Color
  /// </summary>
  public static String? GetColor(BorderType? openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }

  public static void SetColor(BorderType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Color = new StringValue { Value = value };
      else
        openXmlElement.Color = null;
  }

  /// <summary>
  ///   Border Theme Color
  /// </summary>
  public static ThemeColorKind? GetThemeColor(BorderType? openXmlElement)
  {
    return EnumValueConverter.GetValue<ThemeColorValues, ThemeColorKind>(openXmlElement?.ThemeColor?.Value);
  }

  public static void SetThemeColor(BorderType? openXmlElement, ThemeColorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ThemeColor = EnumValueConverter.CreateEnumValue<ThemeColorValues, ThemeColorKind>(value);
  }

  /// <summary>
  ///   Border Theme Color Tint
  /// </summary>
  public static String? GetThemeTint(BorderType? openXmlElement)
  {
    return openXmlElement?.ThemeTint?.Value;
  }

  public static void SetThemeTint(BorderType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ThemeTint = new StringValue { Value = value };
      else
        openXmlElement.ThemeTint = null;
  }

  /// <summary>
  ///   Border Theme Color Shade
  /// </summary>
  public static String? GetThemeShade(BorderType? openXmlElement)
  {
    return openXmlElement?.ThemeShade?.Value;
  }

  public static void SetThemeShade(BorderType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ThemeShade = new StringValue { Value = value };
      else
        openXmlElement.ThemeShade = null;
  }

  /// <summary>
  ///   Border Width
  /// </summary>
  public static UInt32? GetSize(BorderType? openXmlElement)
  {
    return openXmlElement?.Size?.Value;
  }

  public static void SetSize(BorderType? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Size = value;
  }

  /// <summary>
  ///   Border Spacing Measurement
  /// </summary>
  public static UInt32? GetSpace(BorderType? openXmlElement)
  {
    return openXmlElement?.Space?.Value;
  }

  public static void SetSpace(BorderType? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Space = value;
  }

  /// <summary>
  ///   Border Shadow
  /// </summary>
  public static Boolean? GetShadow(BorderType? openXmlElement)
  {
    return openXmlElement?.Shadow?.Value;
  }

  public static void SetShadow(BorderType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Shadow = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Shadow = null;
  }

  /// <summary>
  ///   Create Frame Effect
  /// </summary>
  public static Boolean? GetFrame(BorderType? openXmlElement)
  {
    return openXmlElement?.Frame?.Value;
  }

  public static void SetFrame(BorderType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Frame = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Frame = null;
  }

  public static DocumentModel.Wordprocessing.BorderType? CreateModelElement(BorderType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.BorderType();
      value.Val = GetVal(openXmlElement);
      value.Color = GetColor(openXmlElement);
      value.ThemeColor = GetThemeColor(openXmlElement);
      value.ThemeTint = GetThemeTint(openXmlElement);
      value.ThemeShade = GetThemeShade(openXmlElement);
      value.Size = GetSize(openXmlElement);
      value.Space = GetSpace(openXmlElement);
      value.Shadow = GetShadow(openXmlElement);
      value.Frame = GetFrame(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.BorderType? value)
    where OpenXmlElementType : BorderType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetColor(openXmlElement, value?.Color);
      SetThemeColor(openXmlElement, value?.ThemeColor);
      SetThemeTint(openXmlElement, value?.ThemeTint);
      SetThemeShade(openXmlElement, value?.ThemeShade);
      SetSize(openXmlElement, value?.Size);
      SetSpace(openXmlElement, value?.Space);
      SetShadow(openXmlElement, value?.Shadow);
      SetFrame(openXmlElement, value?.Frame);
      return openXmlElement;
    }
    return default;
  }
}