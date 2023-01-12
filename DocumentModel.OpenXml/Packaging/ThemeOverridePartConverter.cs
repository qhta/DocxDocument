namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ThemeOverridePart
/// </summary>
public static class ThemeOverridePartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.ThemeOverridePart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets the ImageParts of the ThemeOverridePart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart>? GetImageParts(DocumentFormat.OpenXml.Packaging.ThemeOverridePart? openXmlElement)
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
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.ThemeOverridePart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Drawings.ThemeOverride? GetThemeOverride(DocumentFormat.OpenXml.Packaging.ThemeOverridePart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetThemeOverride(DocumentFormat.OpenXml.Packaging.ThemeOverridePart? openXmlElement, DocumentModel.Drawings.ThemeOverride? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  public static DocumentModel.Packaging.ThemeOverridePart? CreateModelElement(DocumentFormat.OpenXml.Packaging.ThemeOverridePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ThemeOverridePart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.ThemeOverride = GetThemeOverride(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.ThemeOverridePart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.ThemeOverridePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetThemeOverride(openXmlElement, value?.ThemeOverride);
      return openXmlElement;
    }
    return default;
  }
}
