namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the EntityTypeEnum enumeration.
/// Used in types such as GeoDataEntityQuery, GeoDataPointQuery, GeoDataPointToEntityQuery.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum EntityTypeEnum
{
  /// <summary>
  ///   Address.
  /// </summary>
  [OpenXmlEnumValue("Address")]
  Address,
  /// <summary>
  ///   AdminDistrict.
  /// </summary>
  [OpenXmlEnumValue("AdminDistrict")]
  AdminDistrict,
  /// <summary>
  ///   AdminDistrict2.
  /// </summary>
  [OpenXmlEnumValue("AdminDistrict2")]
  AdminDistrict2,
  /// <summary>
  ///   AdminDistrict3.
  /// </summary>
  [OpenXmlEnumValue("AdminDistrict3")]
  AdminDistrict3,
  /// <summary>
  ///   Continent.
  /// </summary>
  [OpenXmlEnumValue("Continent")]
  Continent,
  /// <summary>
  ///   CountryRegion.
  /// </summary>
  [OpenXmlEnumValue("CountryRegion")]
  CountryRegion,
  /// <summary>
  ///   Locality.
  /// </summary>
  [OpenXmlEnumValue("Locality")]
  Locality,
  /// <summary>
  ///   Ocean.
  /// </summary>
  [OpenXmlEnumValue("Ocean")]
  Ocean,
  /// <summary>
  ///   Planet.
  /// </summary>
  [OpenXmlEnumValue("Planet")]
  Planet,
  /// <summary>
  ///   PostalCode.
  /// </summary>
  [OpenXmlEnumValue("PostalCode")]
  PostalCode,
  /// <summary>
  ///   Region.
  /// </summary>
  [OpenXmlEnumValue("Region")]
  Region,
  /// <summary>
  ///   Unsupported.
  /// </summary>
  [OpenXmlEnumValue("Unsupported")]
  Unsupported
}
