namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the LineChartExtensionList Class.
/// </summary>
public interface LineChartExtensionList:
{
  public Collection<LineChartExtension>? LineChartExtensions { get; set; }
}