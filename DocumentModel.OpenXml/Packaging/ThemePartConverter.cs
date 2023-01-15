using DocumentFormat.OpenXml.Packaging;
using DocumentModel.Drawings;
using DocumentModel.OpenXml.Drawings;
using ImagePart = DocumentModel.Packaging.ImagePart;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the ThemePart
/// </summary>
public static class ThemePartConverter
{
  public static String? GetContentType(ThemePart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets the ImageParts of the ThemePart
  /// </summary>
  public static Collection<ImagePart>? GetImageParts(ThemePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ImagePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ImagePart>())
      {
        var newItem = ImagePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static String? GetRelationshipType(ThemePart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static Theme? GetTheme(ThemePart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Drawing.Theme rootElement)
      return ThemeConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetTheme(ThemePart? openXmlElement, Theme? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = ThemeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Theme>(value);
        if (rootElement != null)
          openXmlElement.Theme = rootElement;
      }
  }

  public static DocumentModel.Packaging.ThemePart? CreateModelElement(ThemePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ThemePart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.Theme = GetTheme(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.ThemePart? value)
    where OpenXmlElementType : ThemePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      SetTheme(openXmlElement, value?.Theme);
      return openXmlElement;
    }
    return default;
  }
}