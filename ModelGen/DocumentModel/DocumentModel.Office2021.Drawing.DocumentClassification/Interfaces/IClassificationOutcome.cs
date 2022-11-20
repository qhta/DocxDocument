namespace DocumentModel.Office2021.Drawing.DocumentClassification;

/// <summary>
/// Defines the ClassificationOutcome Class.
/// </summary>
public interface IClassificationOutcome // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// classificationOutcomeType, this property is only available in Office 2021 and later.
  /// </summary>
  public DocumentModel.Office2021.Drawing.DocumentClassification.ClassificationOutcomeType? ClassificationOutcomeType { get ; set; }
  
}
