namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Area3DChartExtension Class.
/// </summary>
public class Area3DChartExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }

  public FilteredAreaSeries? FilteredAreaSeries { get; set; }
}