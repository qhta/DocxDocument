namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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