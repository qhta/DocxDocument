namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ThemeOverridePart
/// </summary>
public static class ThemeOverridePartConverter
{
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.ThemeOverridePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the ImageParts of the ThemeOverridePart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart> GetImageParts(DocumentFormat.OpenXml.Packaging.ThemeOverridePart openXmlElement)
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
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.ThemeOverridePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DocumentModel.Drawings.ThemeOverride? GetThemeOverride(DocumentFormat.OpenXml.Packaging.ThemeOverridePart openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Drawing.ThemeOverride rootElement)
      return DocumentModel.OpenXml.Drawings.ThemeOverrideConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetThemeOverride(DocumentFormat.OpenXml.Packaging.ThemeOverridePart openXmlElement, DocumentModel.Drawings.ThemeOverride? value)
  {
    if (value != null)
    {
       var rootElement = DocumentModel.OpenXml.Drawings.ThemeOverrideConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ThemeOverride>(value);
       if (rootElement != null)
         openXmlElement.ThemeOverride = rootElement;
    }
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
      //SetContentType(openXmlElement, value?.ContentType);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      SetThemeOverride(openXmlElement, value?.ThemeOverride);
      return openXmlElement;
    }
    return default;
  }
}
