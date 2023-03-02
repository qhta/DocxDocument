namespace DocumentModel;

/// <summary>
///   Defines the ClassificationExtensionList Class.
/// </summary>
public record ClassificationExtensionList
{
  public Collection<ClassificationExtension>? ClassificationExtensions { get; set; }
}