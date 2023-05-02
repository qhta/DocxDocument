namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BarChartExtension Class.
/// </summary>
public class BarChartExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }

  public FilteredBarSeries? FilteredBarSeries { get; set; }
}