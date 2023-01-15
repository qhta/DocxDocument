using DocumentFormat.OpenXml.Packaging;
using DocumentModel.Drawings.Diagrams;
using DocumentModel.OpenXml.Drawings.Diagrams;
using ImagePart = DocumentModel.Packaging.ImagePart;
using SlidePart = DocumentModel.Packaging.SlidePart;
using WorksheetPart = DocumentModel.Packaging.WorksheetPart;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the DiagramDataPart
/// </summary>
public static class DiagramDataPartConverter
{
  public static String? GetContentType(DiagramDataPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static DataModelRoot? GetDataModelRoot(DiagramDataPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Drawing.Diagrams.DataModelRoot rootElement)
      return DataModelRootConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetDataModelRoot(DiagramDataPart? openXmlElement, DataModelRoot? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = DataModelRootConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.DataModelRoot>(value);
        if (rootElement != null)
          openXmlElement.DataModelRoot = rootElement;
      }
  }

  /// <summary>
  ///   Gets the ImageParts of the DiagramDataPart
  /// </summary>
  public static Collection<ImagePart>? GetImageParts(DiagramDataPart? openXmlElement)
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

  public static String? GetRelationshipType(DiagramDataPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  /// <summary>
  ///   Gets the SlideParts of the DiagramDataPart
  /// </summary>
  public static Collection<SlidePart>? GetSlideParts(DiagramDataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<SlidePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.SlidePart>())
      {
        var newItem = SlidePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the WorksheetParts of the DiagramDataPart
  /// </summary>
  public static Collection<WorksheetPart>? GetWorksheetParts(DiagramDataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<WorksheetPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WorksheetPart>())
      {
        var newItem = WorksheetPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static DocumentModel.Packaging.DiagramDataPart? CreateModelElement(DiagramDataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.DiagramDataPart();
      value.ContentType = GetContentType(openXmlElement);
      value.DataModelRoot = GetDataModelRoot(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.SlideParts = GetSlideParts(openXmlElement);
      value.WorksheetParts = GetWorksheetParts(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.DiagramDataPart? value)
    where OpenXmlElementType : DiagramDataPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      SetDataModelRoot(openXmlElement, value?.DataModelRoot);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      //SetSlideParts(openXmlElement, value?.SlideParts);
      //SetWorksheetParts(openXmlElement, value?.WorksheetParts);
      return openXmlElement;
    }
    return default;
  }
}