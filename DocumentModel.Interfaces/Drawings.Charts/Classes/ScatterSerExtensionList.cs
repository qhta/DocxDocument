namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ScatterSerExtensionList Class.
/// </summary>
public interface ScatterSerExtensionList: IModelElement
{
  public Collection<ScatterSerExtension>? ScatterSerExtensions { get; set; }
}