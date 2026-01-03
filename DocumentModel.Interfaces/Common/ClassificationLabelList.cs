namespace DocumentModel;

/// <summary>
///   Defines the ClassificationLabelList Class.
/// </summary>
public interface ClassificationLabelList: IModelElement
{
  public Collection<ClassificationLabel>? ClassificationLabels { get; set; }
  public ClassificationExtensionList? ClassificationExtensionList { get; set; }
}