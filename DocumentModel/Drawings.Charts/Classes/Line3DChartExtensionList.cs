namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Line3DChartExtensionList Class.
/// </summary>
public record Line3DChartExtensionList
{
  public Collection<Line3DChartExtension>? Line3DChartExtensions { get; set; }
}