namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Pie3DChartExtension Class.
/// </summary>
public record Pie3DChartExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public FilteredPieSeries? FilteredPieSeries { get; set; }
}