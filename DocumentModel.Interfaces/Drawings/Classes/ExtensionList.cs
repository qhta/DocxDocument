namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ExtensionList interface.
/// </summary>
public interface ExtensionList: IModelElement
{
  public Collection<Extension>? Extensions { get; set; }
}