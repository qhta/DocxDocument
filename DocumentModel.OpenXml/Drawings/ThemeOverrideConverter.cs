using DocumentModel.Drawings;
using ThemeOverride = DocumentFormat.OpenXml.Drawing.ThemeOverride;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Theme Override.
/// </summary>
public static class ThemeOverrideConverter
{
  /// <summary>
  ///   Color Scheme.
  /// </summary>
  public static ColorScheme? GetColorScheme(ThemeOverride? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorScheme>();
    if (itemElement != null)
      return ColorSchemeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColorScheme(ThemeOverride? openXmlElement, ColorScheme? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorScheme>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorSchemeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ColorScheme>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   FontScheme.
  /// </summary>
  public static FontScheme? GetFontScheme(ThemeOverride? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FontScheme>();
    if (itemElement != null)
      return FontSchemeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFontScheme(ThemeOverride? openXmlElement, FontScheme? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FontScheme>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FontSchemeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.FontScheme>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   FormatScheme.
  /// </summary>
  public static FormatScheme? GetFormatScheme(ThemeOverride? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FormatScheme>();
    if (itemElement != null)
      return FormatSchemeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFormatScheme(ThemeOverride? openXmlElement, FormatScheme? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FormatScheme>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FormatSchemeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.FormatScheme>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ThemeOverride? CreateModelElement(ThemeOverride? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ThemeOverride();
      value.ColorScheme = GetColorScheme(openXmlElement);
      value.FontScheme = GetFontScheme(openXmlElement);
      value.FormatScheme = GetFormatScheme(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ThemeOverride? value)
    where OpenXmlElementType : ThemeOverride, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetColorScheme(openXmlElement, value?.ColorScheme);
      SetFontScheme(openXmlElement, value?.FontScheme);
      SetFormatScheme(openXmlElement, value?.FormatScheme);
      return openXmlElement;
    }
    return default;
  }
}