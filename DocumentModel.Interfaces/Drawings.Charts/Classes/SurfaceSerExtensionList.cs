namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the SurfaceSerExtensionList Class.
/// </summary>
public interface SurfaceSerExtensionList: IModelElement
{
  public Collection<SurfaceSerExtension>? SurfaceSerExtensions { get; set; }
}