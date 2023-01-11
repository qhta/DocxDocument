namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DiagramPersistLayoutPart
/// </summary>
public static class DiagramPersistLayoutPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Drawings.Office.Drawing? GetDrawing(DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetDrawing(DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart? openXmlElement, DocumentModel.Drawings.Office.Drawing? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramPersistLayoutPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart>? GetImageParts(DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart? openXmlElement)
  {
    if (openXmlElement != null)
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
    return null;
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.DiagramPersistLayoutPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.DiagramPersistLayoutPart();
      value.ContentType = GetContentType(openXmlElement);
      value.Drawing = GetDrawing(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.DiagramPersistLayoutPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
