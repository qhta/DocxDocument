namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the OfficeArtExtensionList Class.
/// </summary>
public class OfficeArtExtensionList: ModelElement
{
  public Collection<Extension>? Extensions { get; set; }
}