namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ExtensionList Class.
/// </summary>
public interface ExtensionList: IModelElement
{
  public Collection<Extension>? Extensions { get; set; }
}