using DocumentModel.Drawings;
using ExtraColorScheme = DocumentFormat.OpenXml.Drawing.ExtraColorScheme;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Extra Color Scheme.
/// </summary>
public static class ExtraColorSchemeConverter
{
  /// <summary>
  ///   ColorScheme.
  /// </summary>
  public static ColorScheme? GetColorScheme(ExtraColorScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorScheme>();
    if (itemElement != null)
      return ColorSchemeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColorScheme(ExtraColorScheme? openXmlElement, ColorScheme? value)
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
  ///   ColorMap.
  /// </summary>
  public static ColorMap? GetColorMap(ExtraColorScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorMap>();
    if (itemElement != null)
      return ColorMapConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColorMap(ExtraColorScheme? openXmlElement, ColorMap? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorMap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorMapConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ColorMap>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ExtraColorScheme? CreateModelElement(ExtraColorScheme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ExtraColorScheme();
      value.ColorScheme = GetColorScheme(openXmlElement);
      value.ColorMap = GetColorMap(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ExtraColorScheme? value)
    where OpenXmlElementType : ExtraColorScheme, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetColorScheme(openXmlElement, value?.ColorScheme);
      SetColorMap(openXmlElement, value?.ColorMap);
      return openXmlElement;
    }
    return default;
  }
}