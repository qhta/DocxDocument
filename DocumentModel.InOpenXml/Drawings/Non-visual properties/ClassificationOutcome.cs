namespace DocumentModel.Drawings;

/// <summary>
/// Represents the outcome of a classification process, including the outcome type and any additional extension data.
/// </summary>
public class ClassificationOutcome: ModelElement<DXO21DDC.ClassificationOutcome>, IExtendableElement
{
  /// <summary>
  /// Classification outcome type.
  /// </summary>
  public ClassificationOutcomeKind? ClassificationOutcomeType { get; set; }

  public IExtensionList? ExtensionList { get; set; }
}