namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ChartSpaceExtensionList Class.
/// </summary>
public record ChartSpaceExtensionList
{
  public Collection<ChartSpaceExtension>? ChartSpaceExtensions { get; set; }
}