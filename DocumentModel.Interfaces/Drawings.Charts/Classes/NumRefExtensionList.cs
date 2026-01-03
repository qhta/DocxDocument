namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the NumRefExtensionList Class.
/// </summary>
public interface NumRefExtensionList: IModelElement
{
  public Collection<NumRefExtension>? NumRefExtensions { get; set; }
}