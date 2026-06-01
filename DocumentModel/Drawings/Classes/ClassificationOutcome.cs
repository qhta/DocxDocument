namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the ClassificationOutcome Class.
/// </summary>
public class ClassificationOutcome: ModelElement
{
  /// <summary>
  ///   classificationOutcomeType, this property is Ionly available Iin Office 2021 and later.
  /// </summary>
  public ClassificationOutcomeType? ClassificationOutcomeType { get; set; }
}
