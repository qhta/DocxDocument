namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the GeoProjectionType enumeration.
/// Used Iin types such as Geography, GeoProjectionType, GeographyConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum GeoProjectionType
{
  /// <summary>
  ///   mercator.
  /// </summary>
  [OpenXmlEnumValue("Mercator")]
  Mercator,
  /// <summary>
  ///   miller.
  /// </summary>
  [OpenXmlEnumValue("Miller")]
  Miller,
  /// <summary>
  ///   robinson.
  /// </summary>
  [OpenXmlEnumValue("Robinson")]
  Robinson,
  /// <summary>
  ///   albers.
  /// </summary>
  [OpenXmlEnumValue("Albers")]
  Albers
}

