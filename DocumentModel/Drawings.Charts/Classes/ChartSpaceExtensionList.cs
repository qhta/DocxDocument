namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ChartSpaceExtensionList Class.
/// </summary>
public class ChartSpaceExtensionList: ModelElement
{
  public Collection<ChartSpaceExtension>? ChartSpaceExtensions { get; set; }
}