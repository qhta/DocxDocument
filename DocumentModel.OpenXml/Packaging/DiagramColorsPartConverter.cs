using DocumentFormat.OpenXml.Packaging;
using DocumentModel.Drawings.Diagrams;
using DocumentModel.OpenXml.Drawings.Diagrams;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the DiagramColorsPart
/// </summary>
public static class DiagramColorsPartConverter
{
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static ColorsDefinition? GetColorsDefinition(DiagramColorsPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition rootElement)
      return ColorsDefinitionConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetColorsDefinition(DiagramColorsPart? openXmlElement, ColorsDefinition? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = ColorsDefinitionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition>(value);
        if (rootElement != null)
          openXmlElement.ColorsDefinition = rootElement;
      }
  }

  public static String? GetContentType(DiagramColorsPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  public static String? GetRelationshipType(DiagramColorsPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.DiagramColorsPart? CreateModelElement(DiagramColorsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.DiagramColorsPart();
      value.ColorsDefinition = GetColorsDefinition(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.DiagramColorsPart? value)
    where OpenXmlElementType : DiagramColorsPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetColorsDefinition(openXmlElement, value?.ColorsDefinition);
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}