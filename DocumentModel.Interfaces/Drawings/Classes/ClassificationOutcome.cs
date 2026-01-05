namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ClassificationOutcome interface.
/// </summary>
public interface ClassificationOutcome :
{
  /// <summary>
  ///   ClassificationOutcomeType
  /// </summary>
  public ClassificationOutcomeType? ClassificationOutcomeType { get; set; }
}