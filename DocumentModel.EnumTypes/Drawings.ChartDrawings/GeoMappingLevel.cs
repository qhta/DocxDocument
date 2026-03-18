namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoMappingLevel enumeration.
/// Used in types such as Geography, GeoMappingLevel, GeographyConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum GeoMappingLevel
{
  /// <summary>
  ///   dataOnly.
  /// </summary>
  [OpenXmlEnumValue("DataOnly")]
  DataOnly,
  /// <summary>
  ///   postalCode.
  /// </summary>
  [OpenXmlEnumValue("PostalCode")]
  PostalCode,
  /// <summary>
  ///   county.
  /// </summary>
  [OpenXmlEnumValue("County")]
  County,
  /// <summary>
  ///   state.
  /// </summary>
  [OpenXmlEnumValue("State")]
  State,
  /// <summary>
  ///   countryRegion.
  /// </summary>
  [OpenXmlEnumValue("CountryRegion")]
  CountryRegion,
  /// <summary>
  ///   countryRegionList.
  /// </summary>
  [OpenXmlEnumValue("CountryRegionList")]
  CountryRegionList,
  /// <summary>
  ///   world.
  /// </summary>
  [OpenXmlEnumValue("World")]
  World
}
