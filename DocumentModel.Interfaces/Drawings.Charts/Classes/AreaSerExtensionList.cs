namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the AreaSerExtensionList Class.
/// </summary>
public interface AreaSerExtensionList: IModelElement
{
  public Collection<AreaSerExtension>? AreaSerExtensions { get; set; }
}