using DocumentFormat.OpenXml.Packaging;
using ImagePart = DocumentModel.Packaging.ImagePart;
using LegacyDiagramTextPart = DocumentModel.Packaging.LegacyDiagramTextPart;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the VmlDrawingPart
/// </summary>
public static class VmlDrawingPartConverter
{
  public static String? GetContentType(VmlDrawingPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets the ImageParts of the VmlDrawingPart
  /// </summary>
  public static Collection<ImagePart>? GetImageParts(VmlDrawingPart? openXmlElement)
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
  ///   Gets the LegacyDiagramTextParts of the VmlDrawingPart
  /// </summary>
  public static Collection<LegacyDiagramTextPart>? GetLegacyDiagramTextParts(VmlDrawingPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<LegacyDiagramTextPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.LegacyDiagramTextPart>())
      {
        var newItem = LegacyDiagramTextPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static String? GetRelationshipType(VmlDrawingPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.VmlDrawingPart? CreateModelElement(VmlDrawingPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.VmlDrawingPart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.LegacyDiagramTextParts = GetLegacyDiagramTextParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.VmlDrawingPart? value)
    where OpenXmlElementType : VmlDrawingPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetLegacyDiagramTextParts(openXmlElement, value?.LegacyDiagramTextParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}