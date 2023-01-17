namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ThemePart
/// </summary>
public static class ThemePartConverter
{
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.ThemePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the ImageParts of the ThemePart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart> GetImageParts(DocumentFormat.OpenXml.Packaging.ThemePart openXmlElement)
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
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.ThemePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DocumentModel.Drawings.Theme? GetTheme(DocumentFormat.OpenXml.Packaging.ThemePart openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Drawing.Theme rootElement)
      return DocumentModel.OpenXml.Drawings.ThemeConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetTheme(DocumentFormat.OpenXml.Packaging.ThemePart openXmlElement, DocumentModel.Drawings.Theme? value)
  {
    if (value != null)
    {
       var rootElement = DocumentModel.OpenXml.Drawings.ThemeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Theme>(value);
       if (rootElement != null)
         openXmlElement.Theme = rootElement;
    }
  }
  
  public static DocumentModel.Packaging.ThemePart? CreateModelElement(DocumentFormat.OpenXml.Packaging.ThemePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ThemePart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.Theme = GetTheme(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.ThemePart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.ThemePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      SetTheme(openXmlElement, value?.Theme);
      return openXmlElement;
    }
    return default;
  }
}
