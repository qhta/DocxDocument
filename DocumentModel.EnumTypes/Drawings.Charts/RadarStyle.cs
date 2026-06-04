namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the RadarStyle enumeration.
/// Used in types such as RadarChart, RadarChartConverter.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Charts.RadarStyleValues))]
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

