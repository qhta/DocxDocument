namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ClassificationExtensionList Class.
/// </summary>
public class ClassificationExtensionList: ModelElement
{
  public Collection<ClassificationExtension>? ClassificationExtensions { get; set; }
}