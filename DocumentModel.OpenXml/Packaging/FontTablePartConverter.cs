using DocumentFormat.OpenXml.Packaging;
using DocumentModel.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using FontPart = DocumentModel.Packaging.FontPart;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the FontTablePart
/// </summary>
public static class FontTablePartConverter
{
  public static String? GetContentType(FontTablePart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets the FontParts of the FontTablePart
  /// </summary>
  public static Collection<FontPart>? GetFontParts(FontTablePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<FontPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.FontPart>())
      {
        var newItem = FontPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static Fonts? GetFonts(FontTablePart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Wordprocessing.Fonts rootElement)
      return FontsConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetFonts(FontTablePart? openXmlElement, Fonts? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = FontsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Fonts>(value);
        if (rootElement != null)
          openXmlElement.Fonts = rootElement;
      }
  }

  public static String? GetRelationshipType(FontTablePart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.FontTablePart? CreateModelElement(FontTablePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.FontTablePart();
      value.ContentType = GetContentType(openXmlElement);
      value.FontParts = GetFontParts(openXmlElement);
      value.Fonts = GetFonts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.FontTablePart? value)
    where OpenXmlElementType : FontTablePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetFontParts(openXmlElement, value?.FontParts);
      SetFonts(openXmlElement, value?.Fonts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}