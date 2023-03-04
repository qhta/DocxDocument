namespace DocumentModel;

/// <summary>
///   Defines the ClassificationLabelList Class.
/// </summary>
public class ClassificationLabelList
{
  public Collection<ClassificationLabel>? ClassificationLabels { get; set; }

  public ClassificationExtensionList? ClassificationExtensionList { get; set; }
}