namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoMappingLevel enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum GeoMappingLevel
{
  /// <summary>
  ///   dataOnly.
  /// </summary>
  DataOnly,
  /// <summary>
  ///   postalCode.
  /// </summary>
  PostalCode,
  /// <summary>
  ///   county.
  /// </summary>
  County,
  /// <summary>
  ///   state.
  /// </summary>
  State,
  /// <summary>
  ///   countryRegion.
  /// </summary>
  CountryRegion,
  /// <summary>
  ///   countryRegionList.
  /// </summary>
  CountryRegionList,
  /// <summary>
  ///   world.
  /// </summary>
  World
}