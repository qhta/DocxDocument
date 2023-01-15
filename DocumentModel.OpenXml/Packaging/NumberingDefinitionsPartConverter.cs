using DocumentFormat.OpenXml.Packaging;
using DocumentModel.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using ImagePart = DocumentModel.Packaging.ImagePart;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the NumberingDefinitionsPart
/// </summary>
public static class NumberingDefinitionsPartConverter
{
  public static String? GetContentType(NumberingDefinitionsPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets the ImageParts of the NumberingDefinitionsPart
  /// </summary>
  public static Collection<ImagePart>? GetImageParts(NumberingDefinitionsPart? openXmlElement)
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

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static Numbering? GetNumbering(NumberingDefinitionsPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Wordprocessing.Numbering rootElement)
      return NumberingConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetNumbering(NumberingDefinitionsPart? openXmlElement, Numbering? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = NumberingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Numbering>(value);
        if (rootElement != null)
          openXmlElement.Numbering = rootElement;
      }
  }

  public static String? GetRelationshipType(NumberingDefinitionsPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.NumberingDefinitionsPart? CreateModelElement(NumberingDefinitionsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.NumberingDefinitionsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.Numbering = GetNumbering(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.NumberingDefinitionsPart? value)
    where OpenXmlElementType : NumberingDefinitionsPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetImageParts(openXmlElement, value?.ImageParts);
      SetNumbering(openXmlElement, value?.Numbering);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}