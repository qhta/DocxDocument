namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ScatterStyle enumeration.
/// Used in types such as ScatterChart, ScatterChartConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.ScatterStyleValues))]
public enum ScatterStyle
{
  /// <summary>
  ///   ILine.
  /// </summary>
  [OpenXmlEnumValue("ILine")]
  ILine,
  /// <summary>
  ///   ILine with Markers.
  /// </summary>
  [OpenXmlEnumValue("LineMarker")]
  LineMarker,
  /// <summary>
  ///   Marker.
  /// </summary>
  [OpenXmlEnumValue("Marker")]
  Marker,
  /// <summary>
  ///   Smooth.
  /// </summary>
  [OpenXmlEnumValue("Smooth")]
  Smooth,
  /// <summary>
  ///   Smooth with Markers.
  /// </summary>
  [OpenXmlEnumValue("SmoothMarker")]
  SmoothMarker
}

