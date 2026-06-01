namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

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
