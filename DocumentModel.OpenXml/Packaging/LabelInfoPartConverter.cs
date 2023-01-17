namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the LabelInfoPart
/// </summary>
public static class LabelInfoPartConverter
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DocumentModel.ClassificationLabelList? GetClassificationLabelList(DocumentFormat.OpenXml.Packaging.LabelInfoPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList rootElement)
      return DocumentModel.OpenXml.ClassificationLabelListConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetClassificationLabelList(DocumentFormat.OpenXml.Packaging.LabelInfoPart openXmlElement, DocumentModel.ClassificationLabelList? value)
  {
    if (value != null)
    {
       var rootElement = DocumentModel.OpenXml.ClassificationLabelListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList>(value);
       if (rootElement != null)
         openXmlElement.ClassificationLabelList = rootElement;
    }
  }
  
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.LabelInfoPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.LabelInfoPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.LabelInfoPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.LabelInfoPart? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.LabelInfoPart, new()
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
