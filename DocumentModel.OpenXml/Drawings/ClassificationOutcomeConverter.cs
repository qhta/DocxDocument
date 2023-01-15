using DocumentModel.Drawings;
using ClassificationOutcome = DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcome;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ClassificationOutcome Class.
/// </summary>
public static class ClassificationOutcomeConverter
{
  /// <summary>
  ///   classificationOutcomeType, this property is only available in Office 2021 and later.
  /// </summary>
  public static ClassificationOutcomeType? GetClassificationOutcomeType(ClassificationOutcome? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcomeType, ClassificationOutcomeType>(openXmlElement?.ClassificationOutcomeType?.Value);
  }

  public static void SetClassificationOutcomeType(ClassificationOutcome? openXmlElement, ClassificationOutcomeType? value)
  {
    if (openXmlElement != null)
      openXmlElement.ClassificationOutcomeType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcomeType, ClassificationOutcomeType>(value);
  }

  public static DocumentModel.Drawings.ClassificationOutcome? CreateModelElement(ClassificationOutcome? openXmlElement)
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
    where OpenXmlElementType : ClassificationOutcome, new()
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