using DocumentFormat.OpenXml.Packaging;
using DocumentModel.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using ImagePart = DocumentModel.Packaging.ImagePart;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the DocumentSettingsPart
/// </summary>
public static class DocumentSettingsPartConverter
{
  public static String? GetContentType(DocumentSettingsPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets the ImageParts of the DocumentSettingsPart
  /// </summary>
  public static Collection<ImagePart>? GetImageParts(DocumentSettingsPart? openXmlElement)
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

  public static String? GetRelationshipType(DocumentSettingsPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static Settings? GetSettings(DocumentSettingsPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Wordprocessing.Settings rootElement)
      return SettingsConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetSettings(DocumentSettingsPart? openXmlElement, Settings? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = SettingsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Settings>(value);
        if (rootElement != null)
          openXmlElement.Settings = rootElement;
      }
  }

  public static DocumentModel.Packaging.DocumentSettingsPart? CreateModelElement(DocumentSettingsPart? openXmlElement)
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
    where OpenXmlElementType : DocumentSettingsPart, new()
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