namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the PieChartExtension Class.
/// </summary>
public class PieChartExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public FilteredPieSeries? FilteredPieSeries { get; set; }
}