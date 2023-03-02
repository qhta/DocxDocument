namespace DocumentModel;

/// <summary>
///   Defines the ClassificationLabelList Class.
/// </summary>
public record ClassificationLabelList
{
  public Collection<ClassificationLabel>? ClassificationLabels { get; set; }

  public ClassificationExtensionList? ClassificationExtensionList { get; set; }
}