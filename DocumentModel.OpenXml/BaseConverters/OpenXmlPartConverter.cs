using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Represents an abstract base class for all OpenXml parts.
/// </summary>
public static class OpenXmlPartConverter
{
  /// <summary>
  ///  Gets the internal part path in the package.
  /// </summary>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  public static Uri? GetUri(OpenXmlPart? openXmlElement)
  {
    return openXmlElement?.Uri;
  }

  /// <summary>
  ///   Gets the content type (MIME type) of the content data in the part.
  /// </summary>
  public static String? GetContentType(OpenXmlPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets the relationship type of the part.
  /// </summary>
  public static String? GetRelationshipType(OpenXmlPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  /// <summary>
  ///   Gets the root element of the current part.
  /// </summary>
  public static ModelElement? GetRootElement(OpenXmlPart? openXmlElement)
  {
    //if (openXmlElement?.RootElement is DocumentFormat.OpenXml.OpenXmlPartRootElement rootElement)
    //  return DocumentModel.OpenXml.ModelElementConverter.CreateModelElement(rootElement);
    return null;
  }

  public static DocumentModel.Packaging.OpenXmlPart? CreateModelElement(OpenXmlPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.OpenXmlPart();
      value.Uri = GetUri(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.RootElement = GetRootElement(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.OpenXmlPart? value)
    where OpenXmlElementType : OpenXmlPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}