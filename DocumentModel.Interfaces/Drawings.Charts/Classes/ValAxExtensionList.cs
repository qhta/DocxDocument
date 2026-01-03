namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ValAxExtensionList Class.
/// </summary>
public interface ValAxExtensionList: IModelElement
{
  public Collection<ValAxExtension>? ValAxExtensions { get; set; }
}