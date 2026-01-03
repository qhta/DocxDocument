namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the DLblsExtensionList Class.
/// </summary>
public interface DLblsExtensionList: IModelElement
{
  public Collection<DLblsExtension>? DLblsExtensions { get; set; }
}