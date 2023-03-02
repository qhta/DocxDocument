namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the PieChartExtensionList Class.
/// </summary>
public record PieChartExtensionList
{
  public Collection<PieChartExtension>? PieChartExtensions { get; set; }
}