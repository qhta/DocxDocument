namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the VmlDrawingPart
/// </summary>
public static class VmlDrawingPartConverter
{
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.VmlDrawingPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the ImageParts of the VmlDrawingPart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart> GetImageParts(DocumentFormat.OpenXml.Packaging.VmlDrawingPart openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart>();
    foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ImagePart>())
    {
      var newItem = DocumentModel.OpenXml.Packaging.ImagePartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  /// <summary>
  /// Gets the LegacyDiagramTextParts of the VmlDrawingPart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.LegacyDiagramTextPart> GetLegacyDiagramTextParts(DocumentFormat.OpenXml.Packaging.VmlDrawingPart openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.LegacyDiagramTextPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.LegacyDiagramTextPart>())
    {
      var newItem = DocumentModel.OpenXml.Packaging.LegacyDiagramTextPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.VmlDrawingPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.VmlDrawingPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.VmlDrawingPart? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.VmlDrawingPart, new()
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
