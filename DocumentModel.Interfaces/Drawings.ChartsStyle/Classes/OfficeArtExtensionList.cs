namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
///   Defines the OfficeArtExtensionList Class.
/// </summary>
public interface OfficeArtExtensionList: IModelElement
{
  public Collection<Extension>? Extensions { get; set; }
}