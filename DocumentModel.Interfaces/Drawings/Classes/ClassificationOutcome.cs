namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ClassificationOutcome interface.
/// </summary>
public interface ClassificationOutcome : IModelElement
{
  /// <summary>
  ///   ClassificationOutcomeType, this property is only available in Office 2021 and later.
  /// </summary>
  public ClassificationOutcomeType? ClassificationOutcomeType { get; set; }
}