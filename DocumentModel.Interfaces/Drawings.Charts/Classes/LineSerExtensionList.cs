namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the LineSerExtensionList Class.
/// </summary>
public interface LineSerExtensionList: IModelElement
{
  public Collection<LineSerExtension>? LineSerExtensions { get; set; }
}