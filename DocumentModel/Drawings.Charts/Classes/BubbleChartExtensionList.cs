namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the BubbleChartExtensionList Class.
/// </summary>
public record BubbleChartExtensionList
{
  public Collection<BubbleChartExtension>? BubbleChartExtensions { get; set; }
}