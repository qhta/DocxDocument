namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Pie3DChartExtension Class.
/// </summary>
public class Pie3DChartExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FilteredPieSeries? FilteredPieSeries { get; set; }
}