namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Pie3DChartExtension Class.
/// </summary>
public interface Pie3DChartExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FilteredPieSeries? FilteredPieSeries { get; set; }
}