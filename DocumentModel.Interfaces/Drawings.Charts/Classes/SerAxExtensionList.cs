namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the SerAxExtensionList Class.
/// </summary>
public interface SerAxExtensionList: IModelElement
{
  public Collection<SerAxExtension>? SerAxExtensions { get; set; }
}