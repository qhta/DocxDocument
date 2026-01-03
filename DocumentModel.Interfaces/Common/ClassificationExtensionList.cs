namespace DocumentModel;

/// <summary>
///   Defines the ClassificationExtensionList Class.
/// </summary>
public interface ClassificationExtensionList: IModelElement
{
  public Collection<ClassificationExtension>? ClassificationExtensions { get; set; }
}