namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the CatAxExtensionList Class.
/// </summary>
public interface CatAxExtensionList: IModelElement
{
  public Collection<CatAxExtension>? CatAxExtensions { get; set; }
}