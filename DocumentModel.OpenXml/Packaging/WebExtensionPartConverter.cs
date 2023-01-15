using DocumentFormat.OpenXml.Packaging;
using DocumentModel.OpenXml.WebExtensions;
using DocumentModel.WebExtensions;
using ImagePart = DocumentModel.Packaging.ImagePart;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the WebExtensionPart
/// </summary>
public static class WebExtensionPartConverter
{
  public static String? GetContentType(WebExtensionPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets the ImageParts of the WebExtensionPart
  /// </summary>
  public static Collection<ImagePart>? GetImageParts(WebExtensionPart? openXmlElement)
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

  public static String? GetRelationshipType(WebExtensionPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static WebExtension? GetWebExtension(WebExtensionPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension rootElement)
      return WebExtensionConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetWebExtension(WebExtensionPart? openXmlElement, WebExtension? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = WebExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension>(value);
        if (rootElement != null)
          openXmlElement.WebExtension = rootElement;
      }
  }

  public static DocumentModel.Packaging.WebExtensionPart? CreateModelElement(WebExtensionPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.WebExtensionPart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.WebExtension = GetWebExtension(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.WebExtensionPart? value)
    where OpenXmlElementType : WebExtensionPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      SetWebExtension(openXmlElement, value?.WebExtension);
      return openXmlElement;
    }
    return default;
  }
}