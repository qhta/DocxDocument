namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the LineChartExtensionList Class.
/// </summary>
public interface LineChartExtensionList: IModelElement
{
  public Collection<LineChartExtension>? LineChartExtensions { get; set; }
}