namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DocumentSettingsPart
/// </summary>
public static class DocumentSettingsPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.DocumentSettingsPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
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
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Wordprocessing.Settings? GetSettings(DocumentFormat.OpenXml.Packaging.DocumentSettingsPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Wordprocessing.Settings rootElement)
      return DocumentModel.OpenXml.Wordprocessing.SettingsConverter.CreateModelElement(rootElement);
    return null;
  }
  
  public static void SetSettings(DocumentFormat.OpenXml.Packaging.DocumentSettingsPart? openXmlElement, DocumentModel.Wordprocessing.Settings? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
         var rootElement = DocumentModel.OpenXml.Wordprocessing.SettingsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Settings>(value);
         if (rootElement != null)
           openXmlElement.Settings = rootElement;
      }
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      SetSettings(openXmlElement, value?.Settings);
      return openXmlElement;
    }
    return default;
  }
}
