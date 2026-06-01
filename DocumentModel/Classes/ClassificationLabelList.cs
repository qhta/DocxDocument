namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the ClassificationLabelList Class.
/// </summary>
public class ClassificationLabelList: ModelElement
{
  public Collection<ClassificationLabel>? ClassificationLabels { get; set; }

  public ClassificationExtensionList? ClassificationExtensionList { get; set; }
}
