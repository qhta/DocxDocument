namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the StrRefExtensionList Class.
/// </summary>
public interface StrRefExtensionList: IModelElement
{
  public Collection<StrRefExtension>? StrRefExtensions { get; set; }
}