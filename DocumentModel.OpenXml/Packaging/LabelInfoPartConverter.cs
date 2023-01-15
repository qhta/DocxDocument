using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the LabelInfoPart
/// </summary>
public static class LabelInfoPartConverter
{
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static ClassificationLabelList? GetClassificationLabelList(LabelInfoPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList rootElement)
      return ClassificationLabelListConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetClassificationLabelList(LabelInfoPart? openXmlElement, ClassificationLabelList? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = ClassificationLabelListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList>(value);
        if (rootElement != null)
          openXmlElement.ClassificationLabelList = rootElement;
      }
  }

  public static String? GetContentType(LabelInfoPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  public static String? GetRelationshipType(LabelInfoPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.LabelInfoPart? CreateModelElement(LabelInfoPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.LabelInfoPart();
      value.ClassificationLabelList = GetClassificationLabelList(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.LabelInfoPart? value)
    where OpenXmlElementType : LabelInfoPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetClassificationLabelList(openXmlElement, value?.ClassificationLabelList);
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}