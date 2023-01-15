using DocumentFormat.OpenXml.Drawing;
using FontCollectionType = DocumentFormat.OpenXml.Drawing.FontCollectionType;
using TextFontType = DocumentModel.Drawings.TextFontType;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the FontCollectionType Class.
/// </summary>
public static class FontCollectionTypeConverter
{
  /// <summary>
  ///   Latin Font.
  /// </summary>
  public static TextFontType? GetLatinFont(FontCollectionType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LatinFont>();
    if (itemElement != null)
      return TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLatinFont(FontCollectionType? openXmlElement, TextFontType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LatinFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextFontTypeConverter.CreateOpenXmlElement<LatinFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   East Asian Font.
  /// </summary>
  public static TextFontType? GetEastAsianFont(FontCollectionType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EastAsianFont>();
    if (itemElement != null)
      return TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEastAsianFont(FontCollectionType? openXmlElement, TextFontType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EastAsianFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextFontTypeConverter.CreateOpenXmlElement<EastAsianFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Complex Script Font.
  /// </summary>
  public static TextFontType? GetComplexScriptFont(FontCollectionType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ComplexScriptFont>();
    if (itemElement != null)
      return TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetComplexScriptFont(FontCollectionType? openXmlElement, TextFontType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ComplexScriptFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextFontTypeConverter.CreateOpenXmlElement<ComplexScriptFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.FontCollectionType? CreateModelElement(FontCollectionType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.FontCollectionType();
      value.LatinFont = GetLatinFont(openXmlElement);
      value.EastAsianFont = GetEastAsianFont(openXmlElement);
      value.ComplexScriptFont = GetComplexScriptFont(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.FontCollectionType? value)
    where OpenXmlElementType : FontCollectionType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLatinFont(openXmlElement, value?.LatinFont);
      SetEastAsianFont(openXmlElement, value?.EastAsianFont);
      SetComplexScriptFont(openXmlElement, value?.ComplexScriptFont);
      return openXmlElement;
    }
    return default;
  }
}