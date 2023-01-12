namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ClassificationOutcome Class.
/// </summary>
public static class ClassificationOutcomeConverter
{
  /// <summary>
  /// classificationOutcomeType, this property is only available in Office 2021 and later.
  /// </summary>
  public static DocumentModel.Drawings.ClassificationOutcomeType? GetClassificationOutcomeType(DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcome? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcomeType, DocumentModel.Drawings.ClassificationOutcomeType>(openXmlElement?.ClassificationOutcomeType?.Value);
  }
  
  public static void SetClassificationOutcomeType(DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcome? openXmlElement, DocumentModel.Drawings.ClassificationOutcomeType? value)
  {
    if (openXmlElement != null)
      openXmlElement.ClassificationOutcomeType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcomeType, DocumentModel.Drawings.ClassificationOutcomeType>(value);
  }
  
  public static DocumentModel.Drawings.ClassificationOutcome? CreateModelElement(DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcome? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ClassificationOutcome();
      value.ClassificationOutcomeType = GetClassificationOutcomeType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ClassificationOutcome? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcome, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetClassificationOutcomeType(openXmlElement, value?.ClassificationOutcomeType);
      return openXmlElement;
    }
    return default;
  }
}
