using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.OpenXml.Vml;
using DocumentModel.Vml;
using DocumentModel.Wordprocessing;
using DocumentBackground = DocumentFormat.OpenXml.Wordprocessing.DocumentBackground;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Document Background.
/// </summary>
public static class DocumentBackgroundConverter
{
  /// <summary>
  ///   color
  /// </summary>
  public static String? GetColor(DocumentBackground? openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }

  public static void SetColor(DocumentBackground? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Color = new StringValue { Value = value };
      else
        openXmlElement.Color = null;
  }

  /// <summary>
  ///   themeColor
  /// </summary>
  public static ThemeColorKind? GetThemeColor(DocumentBackground? openXmlElement)
  {
    return EnumValueConverter.GetValue<ThemeColorValues, ThemeColorKind>(openXmlElement?.ThemeColor?.Value);
  }

  public static void SetThemeColor(DocumentBackground? openXmlElement, ThemeColorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ThemeColor = EnumValueConverter.CreateEnumValue<ThemeColorValues, ThemeColorKind>(value);
  }

  /// <summary>
  ///   themeTint
  /// </summary>
  public static String? GetThemeTint(DocumentBackground? openXmlElement)
  {
    return openXmlElement?.ThemeTint?.Value;
  }

  public static void SetThemeTint(DocumentBackground? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ThemeTint = new StringValue { Value = value };
      else
        openXmlElement.ThemeTint = null;
  }

  /// <summary>
  ///   themeShade
  /// </summary>
  public static String? GetThemeShade(DocumentBackground? openXmlElement)
  {
    return openXmlElement?.ThemeShade?.Value;
  }

  public static void SetThemeShade(DocumentBackground? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ThemeShade = new StringValue { Value = value };
      else
        openXmlElement.ThemeShade = null;
  }

  /// <summary>
  ///   Background.
  /// </summary>
  public static Background? GetBackground(DocumentBackground? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Background>();
    if (itemElement != null)
      return BackgroundConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackground(DocumentBackground? openXmlElement, Background? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Background>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackgroundConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Background>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.DocumentBackground? CreateModelElement(DocumentBackground? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DocumentBackground();
      value.Color = GetColor(openXmlElement);
      value.ThemeColor = GetThemeColor(openXmlElement);
      value.ThemeTint = GetThemeTint(openXmlElement);
      value.ThemeShade = GetThemeShade(openXmlElement);
      value.Background = GetBackground(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DocumentBackground? value)
    where OpenXmlElementType : DocumentBackground, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetColor(openXmlElement, value?.Color);
      SetThemeColor(openXmlElement, value?.ThemeColor);
      SetThemeTint(openXmlElement, value?.ThemeTint);
      SetThemeShade(openXmlElement, value?.ThemeShade);
      SetBackground(openXmlElement, value?.Background);
      return openXmlElement;
    }
    return default;
  }
}