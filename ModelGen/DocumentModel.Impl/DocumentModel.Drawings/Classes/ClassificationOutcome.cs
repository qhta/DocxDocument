namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ClassificationOutcome Class.
/// </summary>
public class ClassificationOutcomeImpl: ModelElementImpl, ClassificationOutcome
{
  public DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcome? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcome?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// classificationOutcomeType, this property is only available in Office 2021 and later.
  /// </summary>
  public ClassificationOutcomeType? ClassificationOutcomeType
  {
    get => (ClassificationOutcomeType?)OpenXmlElement?.ClassificationOutcomeType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ClassificationOutcomeType = (DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcomeType?)value;
    }
  }
  
}
