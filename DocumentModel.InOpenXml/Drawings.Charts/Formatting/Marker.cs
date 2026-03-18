namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a marker in a chart, typically for line or scatter charts.
///   This class defines the visual appearance, size, and shape properties of the marker.
/// </summary>
[OpenXmlType(typeof(DXDC.Marker))]
public partial class Marker : ModelElement<DXDC.Marker>
{
  /// <summary>
  ///   Symbol style of the marker.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.Marker.Symbol))]
  public MarkerStyle? Symbol { get; set; }

  /// <summary>
  ///   Size of the marker.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.Marker.Size))]
  public Byte? Size { get; set; }

  /// <summary>
  ///   Visual and shape properties for the marker.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.Marker.ChartShapeProperties))]
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   Collection of extension elements for additional marker customization.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.Marker.ExtensionList))]
  public ExtensionList? ExtensionList { get; set; }
}
