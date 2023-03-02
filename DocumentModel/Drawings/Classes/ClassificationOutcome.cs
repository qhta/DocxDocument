namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ClassificationOutcome Class.
/// </summary>
public record ClassificationOutcome
{
  /// <summary>
  ///   classificationOutcomeType, this property is only available in Office 2021 and later.
  /// </summary>
  public ClassificationOutcomeType? ClassificationOutcomeType { get; set; }
}