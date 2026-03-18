namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the RadarStyle enumeration.
/// Used in types such as RadarChart, RadarChartConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.RadarStyleValues))]
public enum RadarStyle
{
  /// <summary>
  ///   Standard.
  /// </summary>
  [OpenXmlEnumValue("Standard")]
  Standard,
  /// <summary>
  ///   Marker.
  /// </summary>
  [OpenXmlEnumValue("Marker")]
  Marker,
  /// <summary>
  ///   Filled.
  /// </summary>
  [OpenXmlEnumValue("Filled")]
  Filled
}
