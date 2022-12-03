namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ClassificationOutcome Class.
/// </summary>
public interface ClassificationOutcome // : System.Boolean
{
  /// <summary>
  /// classificationOutcomeType, this property is only available in Office 2021 and later.
  /// </summary>
  public ClassificationOutcomeType? ClassificationOutcomeType { get ; set; }
  
}
