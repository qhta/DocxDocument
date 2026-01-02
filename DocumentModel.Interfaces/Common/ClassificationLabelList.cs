namespace DocumentModel;

/// <summary>
///   Defines the ClassificationLabelList Class.
/// </summary>
public class ClassificationLabelList: ModelElement
{
  public Collection<ClassificationLabel>? ClassificationLabels { get; set; }
  public ClassificationExtensionList? ClassificationExtensionList { get; set; }
}