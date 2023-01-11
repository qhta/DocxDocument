namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DocumentSettingsPart
/// </summary>
public static class DocumentSettingsPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.DocumentSettingsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets the ImageParts of the DocumentSettingsPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart>? GetImageParts(DocumentFormat.OpenXml.Packaging.DocumentSettingsPart? openXmlElement)
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
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.DocumentSettingsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Wordprocessing.Settings? GetSettings(DocumentFormat.OpenXml.Packaging.DocumentSettingsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetSettings(DocumentFormat.OpenXml.Packaging.DocumentSettingsPart? openXmlElement, DocumentModel.Wordprocessing.Settings? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  public static DocumentModel.Packaging.DocumentSettingsPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.DocumentSettingsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.DocumentSettingsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.Settings = GetSettings(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.DocumentSettingsPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.DocumentSettingsPart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
