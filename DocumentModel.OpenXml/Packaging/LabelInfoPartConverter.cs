namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the LabelInfoPart
/// </summary>
public static class LabelInfoPartConverter
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.ClassificationLabelList? GetClassificationLabelList(DocumentFormat.OpenXml.Packaging.LabelInfoPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetClassificationLabelList(DocumentFormat.OpenXml.Packaging.LabelInfoPart? openXmlElement, DocumentModel.ClassificationLabelList? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.LabelInfoPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.LabelInfoPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
