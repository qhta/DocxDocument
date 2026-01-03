namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ChartSpaceExtensionList Class.
/// </summary>
public interface ChartSpaceExtensionList: IModelElement
{
  public Collection<ChartSpaceExtension>? ChartSpaceExtensions { get; set; }
}