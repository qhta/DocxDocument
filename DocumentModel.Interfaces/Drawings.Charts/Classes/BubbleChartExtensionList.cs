namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the BubbleChartExtensionList Class.
/// </summary>
public interface BubbleChartExtensionList: IModelElement
{
  public Collection<BubbleChartExtension>? BubbleChartExtensions { get; set; }
}