namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the DLblExtensionList Class.
/// </summary>
public interface DLblExtensionList: IModelElement
{
  public Collection<DLblExtension>? DLblExtensions { get; set; }
}