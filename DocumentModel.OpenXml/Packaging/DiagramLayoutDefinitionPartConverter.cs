using DocumentFormat.OpenXml.Packaging;
using DocumentModel.Drawings.Diagrams;
using DocumentModel.OpenXml.Drawings.Diagrams;
using ImagePart = DocumentModel.Packaging.ImagePart;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the DiagramLayoutDefinitionPart
/// </summary>
public static class DiagramLayoutDefinitionPartConverter
{
  public static String? GetContentType(DiagramLayoutDefinitionPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets the ImageParts of the DiagramLayoutDefinitionPart
  /// </summary>
  public static Collection<ImagePart>? GetImageParts(DiagramLayoutDefinitionPart? openXmlElement)
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
  public static LayoutDefinition? GetLayoutDefinition(DiagramLayoutDefinitionPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition rootElement)
      return LayoutDefinitionConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetLayoutDefinition(DiagramLayoutDefinitionPart? openXmlElement, LayoutDefinition? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = LayoutDefinitionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition>(value);
        if (rootElement != null)
          openXmlElement.LayoutDefinition = rootElement;
      }
  }

  public static String? GetRelationshipType(DiagramLayoutDefinitionPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.DiagramLayoutDefinitionPart? CreateModelElement(DiagramLayoutDefinitionPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.DiagramLayoutDefinitionPart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.LayoutDefinition = GetLayoutDefinition(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.DiagramLayoutDefinitionPart? value)
    where OpenXmlElementType : DiagramLayoutDefinitionPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetImageParts(openXmlElement, value?.ImageParts);
      SetLayoutDefinition(openXmlElement, value?.LayoutDefinition);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}