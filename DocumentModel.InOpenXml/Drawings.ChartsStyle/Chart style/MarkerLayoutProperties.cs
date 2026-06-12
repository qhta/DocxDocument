using DocumentModel.Drawings.Charts;

namespace DocumentModel.Drawings.ChartsStyle;
/// <summary>
/// Describes the layout properties for chart markers, including symbol type and size settings.
/// </summary>
[XmlRoot("MarkerLayoutProperties", Namespace = "DocumentModel.Drawings.ChartsStyle")]
public partial class MarkerLayoutProperties
{
  /// <summary>
  /// Marker symbol type used for data points in the chart.
  /// </summary>
  public MarkerStyle? Symbol { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Size value for the marker symbols.
  /// </summary>
  public Byte? Size { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}