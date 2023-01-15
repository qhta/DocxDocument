using DocumentFormat.OpenXml.Packaging;
using DocumentModel.Drawings.Diagrams;
using DocumentModel.OpenXml.Drawings.Diagrams;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the DiagramStylePart
/// </summary>
public static class DiagramStylePartConverter
{
  public static String? GetContentType(DiagramStylePart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  public static String? GetRelationshipType(DiagramStylePart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static StyleDefinition? GetStyleDefinition(DiagramStylePart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition rootElement)
      return StyleDefinitionConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetStyleDefinition(DiagramStylePart? openXmlElement, StyleDefinition? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = StyleDefinitionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition>(value);
        if (rootElement != null)
          openXmlElement.StyleDefinition = rootElement;
      }
  }

  public static DocumentModel.Packaging.DiagramStylePart? CreateModelElement(DiagramStylePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.DiagramStylePart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.StyleDefinition = GetStyleDefinition(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.DiagramStylePart? value)
    where OpenXmlElementType : DiagramStylePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      SetStyleDefinition(openXmlElement, value?.StyleDefinition);
      return openXmlElement;
    }
    return default;
  }
}