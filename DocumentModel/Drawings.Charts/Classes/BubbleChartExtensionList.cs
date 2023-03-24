namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BubbleChartExtensionList Class.
/// </summary>
public class BubbleChartExtensionList: ModelElement
{
  public Collection<BubbleChartExtension>? BubbleChartExtensions { get; set; }
}