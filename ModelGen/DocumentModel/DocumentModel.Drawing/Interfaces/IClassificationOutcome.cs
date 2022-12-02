namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ClassificationOutcome Class.
/// </summary>
public interface IClassificationOutcome // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// classificationOutcomeType, this property is only available in Office 2021 and later.
  /// </summary>
  public ClassificationOutcomeType? ClassificationOutcomeType { get ; set; }
  
}
