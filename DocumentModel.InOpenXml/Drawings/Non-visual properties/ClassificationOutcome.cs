namespace DocumentModel.Drawings;

/// <summary>
/// Represents the outcome of a classification process, including the outcome type and any additional extension data.
/// </summary>
public interface ClassificationOutcome: IExtendableElement
{
  /// <summary>
  /// Classification outcome type.
  /// </summary>
  public ClassificationOutcomeType? ClassificationOutcomeType { get; set; }
}