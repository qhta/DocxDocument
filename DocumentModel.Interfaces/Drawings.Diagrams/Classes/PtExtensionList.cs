namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the PtExtensionList Class.
/// </summary>
public interface PtExtensionList: IModelElement
{
  public Collection<PtExtension>? PtExtensions { get; set; }
}