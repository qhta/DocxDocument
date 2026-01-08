namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for 3D Area Charts, providing additional series filtering capabilities.
/// </summary>
public interface Area3DChartExtension : Extension
{
  /// <summary>
  ///   Specifies the filtered area series for the chart extension.
  /// </summary>
  public FilteredAreaSeries? FilteredAreaSeries { get; set; }
}